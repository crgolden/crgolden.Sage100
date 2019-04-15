namespace Clarity.Sage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

    public static class DispatchObjectExtensions
    {
        public static DispatchObject GetBusObj(
            this DispatchObject provideX,
            DispatchObject session,
            string moduleName,
            string programName,
            string busObjName)
        {
            session.InvokeMethod("nSetDate", moduleName, $"{DateTime.Now:yyyyMMdd}");
            session.InvokeMethod("nSetModule", moduleName);
            var taskID = (int)session.InvokeMethod("nLookupTask", programName);
            session.InvokeMethod("nSetProgram", taskID);
            return new DispatchObject(provideX.InvokeMethod("NewObject", new object[]
            {
                busObjName,
                session.GetObject()
            }));
        }

        public static async Task<Dictionary<EntityState, T[]>> GetGroupedRecords<T>(
            this DispatchObject busObj,
            DateTime? compareDate,
            Func<string, EntityState, Task<T>> selector,
            string groupedKeysDescColumn,
            string recordsDescColumn,
            string keyColumn,
            string filter,
            string begin,
            string end,
            Func<IEnumerable<string>, string, string> keyFilter)
            where T : Record
        {
            var dictionary = new Dictionary<EntityState, T[]>();
            var keyValuePairs = busObj.GetGroupedKeys<T>(
                compareDate: compareDate,
                descColumn: groupedKeysDescColumn,
                keyColumn: keyColumn,
                filter: filter,
                begin: begin,
                end: end);
            foreach (var keyValuePair in keyValuePairs)
            {
                var entities = await busObj.GetRecords(
                    selector: selector,
                    descColumn: recordsDescColumn,
                    keyColumn: keyColumn,
                    state: keyValuePair.Key,
                    keys: keyValuePair.Value,
                    keyFilter: keyFilter).ConfigureAwait(false);
                dictionary.Add(keyValuePair.Key, entities);
            }

            return dictionary;
        }

        public static async Task<T> GetRecord<T>(
            this DispatchObject busObj,
            DbContext context,
            IMapper mapper,
            ILogger logger,
            EntityState state,
            string record,
            Func<DbContext, string[], EntityState, CancellationToken, Task<Action<IMappingOperationOptions>>>[] opts,
            CancellationToken token)
            where T : Record
        {
            async Task<T> GetRecord(string[] recordProperties)
            {
                try
                {
                    return mapper.Map<string[], T>(
                            source: recordProperties,
                            opts: await opts[0](context, recordProperties, state, token).ConfigureAwait(false));
                }
                catch (AutoMapperMappingException e)
                {
                    logger.LogError(
                        exception: e,
                        message: "Error mapping values {@record} to type {@type}",
                        args: new object[] { recordProperties, typeof(T).Name });
                    return default;
                }
            }

            var recordValues = record.Split(new[] { Record.Sep }, StringSplitOptions.None);
            if (recordValues.Length > 1) return await GetRecord(recordValues).ConfigureAwait(false);
            busObj.InvokeMethod("nSetKey", record);
            record = (string)busObj.InvokeMethod("nGetOrigRecord$");
            recordValues = record.Split('Š');
            return await GetRecord(recordValues).ConfigureAwait(false);
        }

        public static async Task<THeader> GetSalesOrderHeader<THeader, TLine>(
            this DispatchObject busObj,
            DbContext context,
            IMapper mapper,
            ILogger logger,
            EntityState state,
            string record,
            Func<DbContext, string[], EntityState, CancellationToken, Task<Action<IMappingOperationOptions>>>[] opts,
            CancellationToken token)
            where THeader : SalesOrderHeader<TLine>
            where TLine : SalesOrderDetail
        {
            var salesOrderHeader = await busObj.GetRecord<THeader>(
                context: context,
                mapper: mapper,
                logger: logger,
                state: state,
                record: record,
                opts: opts,
                token: token).ConfigureAwait(false);
            if (salesOrderHeader.Equals(default(THeader))) return default;
            using (var oLines = new DispatchObject(busObj.GetProperty("oLines")))
            {
                oLines.InvokeMethod("nMoveFirst");
                salesOrderHeader.Lines = await oLines.GetLines(
                        context: context,
                        mapper: mapper,
                        state: state,
                        opts: opts[1],
                        lines: new HashSet<TLine>(),
                        token: token).ConfigureAwait(false);
            }

            return salesOrderHeader;
        }

        private static Dictionary<EntityState, string[]> GetGroupedKeys<T>(
            this DispatchObject busObj,
            DateTime? compareDate,
            string descColumn,
            string keyColumn,
            string filter,
            string begin,
            string end)
            where T : Record
        {
            var args = new[]
            {
                descColumn,
                keyColumn,
                string.Empty,
                string.Empty,
                filter,
                begin,
                end
            };
            busObj.InvokeMethodByRef("nGetResultSets", args);
            var dateTimes = args[2].Split('Š');
            var keys = args[3].Split('Š');
            var tuples = dateTimes
                .Zip(keys, (dateTime, key) => !string.IsNullOrEmpty(key) && !string.IsNullOrWhiteSpace(key)
                    ? Tuple.Create(dateTime, key)
                    : null)
                .Where(x => x != null)
                .ToArray();
            return compareDate.HasValue
                ? compareDate.Value.ToGroupedKeys(tuples)
                : new Dictionary<EntityState, string[]>
                {
                    {
                        EntityState.Added,
                        keys.Where(x => !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x)).ToArray()
                    }
                };
        }

        private static async Task<ICollection<T>> GetLines<T>(
            this DispatchObject busObj,
            DbContext context,
            IMapper mapper,
            EntityState state,
            Func<DbContext, string[], EntityState, CancellationToken, Task<Action<IMappingOperationOptions>>> opts,
            ICollection<T> lines,
            CancellationToken token)
            where T : SalesOrderDetail
        {
            var line = (string)busObj.InvokeMethod("nGetOrigRecord$");
            if (string.IsNullOrEmpty(line)) return lines;
            var lineValues = line.Split('Š');
            var lineDetail = mapper.Map<string[], T>(
                    source: lineValues,
                    opts: await opts(context, lineValues, state, token).ConfigureAwait(false));
            lines.Add(lineDetail);
            busObj.InvokeMethod("nMoveNext");
            int isEof = (int)busObj.GetProperty("nEOF");
            return isEof == 1 ? lines : await busObj.GetLines(
                context: context,
                mapper: mapper,
                state: state,
                opts: opts,
                lines: lines,
                token: token).ConfigureAwait(false);
        }

        private static async Task<T[]> GetRecords<T>(
            this DispatchObject busObj,
            Func<string, EntityState, Task<T>> selector,
            string descColumn,
            string keyColumn,
            EntityState state,
            string[] keys,
            Func<IEnumerable<string>, string, string> keyFilter)
            where T : Record
        {
            var records = new List<T>();
            int skip = 0, take = 250, remainder = keys.Length % take;
            for (var i = 0; i < keys.Length / take; i++)
            {
                records.AddRange(await busObj.GetRecords(
                    selector: selector,
                    descColumn: descColumn,
                    keyColumn: keyColumn,
                    state: state,
                    keys: keys.Skip(skip).Take(take),
                    keyFilter: keyFilter).ConfigureAwait(false));
                skip += take;
            }

            if (remainder > 0)
            {
                records.AddRange(await busObj.GetRecords(
                    selector: selector,
                    descColumn: descColumn,
                    keyColumn: keyColumn,
                    state: state,
                    keys: keys.Skip(skip).Take(remainder),
                    keyFilter: keyFilter).ConfigureAwait(false));
            }

            return records.ToArray();
        }

        private static async Task<IEnumerable<T>> GetRecords<T>(
            this DispatchObject busObj,
            Func<string, EntityState, Task<T>> selector,
            string descColumn,
            string keyColumn,
            EntityState state,
            IEnumerable<string> keys,
            Func<IEnumerable<string>, string, string> keyFilter)
            where T : Record
        {
            var args = new[]
            {
                descColumn,
                keyColumn,
                string.Empty,
                string.Empty,
                keyFilter(keys, keyColumn),
                string.Empty,
                string.Empty
            };
            busObj.InvokeMethodByRef("nGetResultSets", args);
            return await Task.WhenAll(args[2]
                    .Split('Š')
                    .Where(x => !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x))
                    .Select(async x => await selector(x, state).ConfigureAwait(false)))
                .ConfigureAwait(false);
        }
    }
}
