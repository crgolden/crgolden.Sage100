namespace crgolden.Sage
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

    public static class BoiServiceExtensions
    {
        public static BoiService GetBusObj(
            this BoiService provideX,
            BoiService session,
            string moduleName,
            string programName,
            string busObjName)
        {
            session.InvokeMethod("nSetDate", moduleName, $"{DateTime.Now:yyyyMMdd}");
            session.InvokeMethod("nSetModule", moduleName);
            var taskID = (int)session.InvokeMethod("nLookupTask", programName);
            session.InvokeMethod("nSetProgram", taskID);
            return new BoiService(provideX.InvokeMethod("NewObject", new object[]
            {
                busObjName,
                session.GetObject()
            }));
        }

        public static async Task<Dictionary<EntityState, T[]>> GetGroupedRecords<T>(
            this BoiService busObj,
            DateTime? compareDate,
            DbContext context,
            Func<BoiService, string, EntityState, CancellationToken, Task<T>> selector,
            string groupedKeysDescColumn,
            string recordsDescColumn,
            string keyColumn,
            string filter,
            string begin,
            string end,
            Func<IEnumerable<string>, string, string> keyFilter,
            CancellationToken token)
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
                    keyFilter: keyFilter,
                    token: token).ConfigureAwait(false);
                dictionary.Add(keyValuePair.Key, entities);
                //dictionary.Add(
                //    key: keyValuePair.Key,
                //    value: await entities.ProcessAsync(context, token).ConfigureAwait(false));
            }

            return dictionary;
        }

        public static async Task<T> GetRecord<T>(
            this BoiService busObj,
            DbContext context,
            IMapper mapper,
            ILogger logger,
            EntityState state,
            string record,
            Func<DbContext, string[], EntityState, CancellationToken, Task<Action<IMappingOperationOptions>>>[] opts,
            CancellationToken token)
            where T : Record
        {
            async Task<T> GetRecord(string[] recordProperties) => await Map<T>(
                context: context,
                mapper: mapper,
                logger: logger,
                state: state,
                opts: opts[0],
                properties: recordProperties,
                token: token).ConfigureAwait(false);

            var recordValues = record.Split(new[] { Record.Sep }, StringSplitOptions.None);
            if (recordValues.Length > 1) return await GetRecord(recordValues).ConfigureAwait(false);
            busObj.InvokeMethod("nSetKey", record);
            record = (string)busObj.InvokeMethod("nGetOrigRecord$");
            recordValues = record.Split('Š');
            return await GetRecord(recordValues).ConfigureAwait(false);
        }

        public static async Task<THeader> GetSalesOrderHeader<THeader, TLine>(
            this BoiService busObj,
            DbContext context,
            IMapper mapper,
            ILogger logger,
            EntityState state,
            string record,
            string[] lineColumns,
            Func<DbContext, string[], EntityState, CancellationToken, Task<Action<IMappingOperationOptions>>>[] opts,
            CancellationToken token,
            Func<
                BoiService,
                THeader,
                DbContext,
                IMapper,
                ILogger,
                EntityState,
                string[],
                Func<DbContext,
                    string[],
                    EntityState,
                    CancellationToken,
                    Task<Action<IMappingOperationOptions>>>,
                CancellationToken,
                Task
            > setLines)
            where THeader : SalesOrderHeader<TLine>
            where TLine : SalesOrderDetail
        {
            var header = await busObj.GetRecord<THeader>(
                context: context,
                mapper: mapper,
                logger: logger,
                state: state,
                record: record,
                opts: opts,
                token: token).ConfigureAwait(false);
            if (header.Equals(default(THeader))) return default;
            var lines = busObj.GetProperty("oLines");
            if (lines == null) return header;
            using (var oLines = new BoiService(lines))
            {
                oLines.InvokeMethod("nMoveFirst");
                await setLines(
                    arg1: oLines,
                    arg2: header,
                    arg3: context,
                    arg4: mapper,
                    arg5: logger,
                    arg6: state,
                    arg7: lineColumns,
                    arg8: opts[1],
                    arg9: token).ConfigureAwait(false);
            }

            return header;
        }

        private static Dictionary<EntityState, string[]> GetGroupedKeys<T>(
            this BoiService busObj,
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

        public static async Task SetInvoiceHeaderLines<THeader, TLine>(
            this BoiService busObj,
            THeader invoice,
            DbContext context,
            IMapper mapper,
            ILogger logger,
            EntityState state,
            string[] lineColumns,
            Func<
                DbContext,
                string[],
                EntityState,
                CancellationToken,
                Task<Action<IMappingOperationOptions>>
                > opts,
            CancellationToken token)
            where THeader : InvoiceHeader<TLine>
            where TLine : InvoiceDetail
        {
            var isEof = (int)busObj.GetProperty("nEOF");
            if (isEof == 1) return;
            invoice.Lines = invoice.Lines ?? new HashSet<TLine>();
            var value = new object[2];
            value[0] = "InvoiceNo$";
            value[1] = string.Empty;
            busObj.InvokeMethodByRef("nGetValue", value);
            if ($"{value[1]}" != invoice.InvoiceNo)
            {
                Debug.WriteLine($"InvoiceNo: {value[1]}");
                busObj.InvokeMethod("nMoveNext");
                await busObj.SetInvoiceHeaderLines<THeader, TLine>(
                    invoice: invoice,
                    context: context,
                    mapper: mapper,
                    logger: logger,
                    state: state,
                    lineColumns: lineColumns,
                    opts: opts,
                    token: token).ConfigureAwait(false);
                return;
            }

            var line = await busObj.GetLine<TLine>(
                context: context,
                mapper: mapper,
                logger: logger,
                state: state,
                opts: opts,
                token: token,
                lineColumns: lineColumns,
                value: value).ConfigureAwait(false);
            if (line != default && !string.IsNullOrEmpty(line.LineKey)) invoice.Lines.Add(line);
            busObj.InvokeMethod("nMoveNext");
            await busObj.SetInvoiceHeaderLines<THeader, TLine>(
                invoice: invoice,
                context: context,
                mapper: mapper,
                logger: logger,
                state: state,
                lineColumns: lineColumns,
                opts: opts,
                token: token).ConfigureAwait(false);
        }

        public static async Task SetSalesOrderHeaderLines<THeader, TLine>(
            this BoiService busObj,
            THeader order,
            DbContext context,
            IMapper mapper,
            ILogger logger,
            EntityState state,
            string[] lineColumns,
            Func<
                DbContext,
                string[],
                EntityState,
                CancellationToken,
                Task<Action<IMappingOperationOptions>>
                > opts,
            CancellationToken token)
            where THeader : SalesOrderHeader<TLine>
            where TLine : SalesOrderDetail
        {
            var isEof = (int)busObj.GetProperty("nEOF");
            if (isEof == 1) return;
            order.Lines = order.Lines ?? new HashSet<TLine>();
            var line = await busObj.GetLine<TLine>(
                context: context,
                mapper: mapper,
                logger: logger,
                state: state,
                opts: opts,
                token: token,
                lineColumns: lineColumns,
                value: new object[2]).ConfigureAwait(false);
            if (line != default && !string.IsNullOrEmpty(line.LineKey)) order.Lines.Add(line);
            busObj.InvokeMethod("nMoveNext");
            await busObj.SetSalesOrderHeaderLines<THeader, TLine>(
                order: order,
                context: context,
                mapper: mapper,
                logger: logger,
                state: state,
                lineColumns: lineColumns,
                opts: opts,
                token: token).ConfigureAwait(false);
        }

        private static async Task<TLine> GetLine<TLine>(
            this BoiService busObj,
            DbContext context,
            IMapper mapper,
            ILogger logger,
            EntityState state,
            Func<
                DbContext,
                string[],
                EntityState,
                CancellationToken,
                Task<Action<IMappingOperationOptions>>
                > opts,
            CancellationToken token,
            string[] lineColumns,
            object[] value)
        {
            var lineProperties = new string[lineColumns.Length];
            for (var i = 0; i < lineProperties.Length; i++)
            {
                value[0] = lineColumns[i];
                value[1] = lineColumns[i].EndsWith("$") ? (object)string.Empty : (object)0;
                busObj.InvokeMethodByRef("nGetValue", value);
                lineProperties[i] = $"{value[1]}";
            }

            return await Map<TLine>(
                context: context,
                mapper: mapper,
                logger: logger,
                state: state,
                opts: opts,
                properties: lineProperties,
                token: token).ConfigureAwait(false);
        }

        private static async Task<T[]> GetRecords<T>(
            this BoiService busObj,
            Func<BoiService, string, EntityState, CancellationToken, Task<T>> selector,
            string descColumn,
            string keyColumn,
            EntityState state,
            string[] keys,
            Func<IEnumerable<string>, string, string> keyFilter,
            CancellationToken token)
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
                    keyFilter: keyFilter,
                    token: token).ConfigureAwait(false));
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
                    keyFilter: keyFilter,
                    token: token).ConfigureAwait(false));
            }

            return records.ToArray();
        }

        private static async Task<IEnumerable<T>> GetRecords<T>(
            this BoiService busObj,
            Func<BoiService, string, EntityState, CancellationToken, Task<T>> selector,
            string descColumn,
            string keyColumn,
            EntityState state,
            IEnumerable<string> keys,
            Func<IEnumerable<string>, string, string> keyFilter,
            CancellationToken token)
            where T : Record
        {
            var records = new List<T>();
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
            foreach (var result in args[2]
                .Split('Š')
                .Where(x => !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x))
                .Zip(keys, (record, key) => Tuple.Create(record, key)))
            {
                busObj.InvokeMethod("nSetKey", result.Item2);
                var record = await selector(busObj, result.Item1, state, token).ConfigureAwait(false);
                if (record != default) records.Add(record);
            }

            return records.ToArray();
        }

        private static async Task<T> Map<T>(
            DbContext context,
            IMapper mapper,
            ILogger logger,
            EntityState state,
            Func<DbContext, string[], EntityState, CancellationToken, Task<Action<IMappingOperationOptions>>> opts,
            string[] properties,
            CancellationToken token)
        {
            try
            {
                return mapper.Map<string[], T>(
                    source: properties,
                    opts: await opts(context, properties, state, token).ConfigureAwait(false));
            }
            catch (AutoMapperMappingException e)
            {
                logger.LogError(
                    exception: e,
                    message: "Error mapping values {@record} to type {@type}",
                    args: new object[] { properties, typeof(T).Name });
                throw;
            }
        }
    }
}
