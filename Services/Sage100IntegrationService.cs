namespace crgolden.Sage100
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;

    // https://sagecity.na.sage.com/support_communities/sage100_erp/f/sage-100-business-object-interface/41828/help-sample-code-c
    public class Sage100IntegrationService : IDisposable, IIntegrationService
    {
        private readonly Type _type;
        private object _instance;
        private readonly IOptions<Sage100Options> _sage100Options;
        private readonly IMapper _mapper;
        private readonly ILogger<Sage100IntegrationService> _logger;
        private const BindingFlags InvokeFlags = BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.InvokeMethod;
        private const BindingFlags GetFlags = BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.GetProperty;
        private const BindingFlags SetFlags = BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.SetProperty;

        private static IEnumerable<Type> NumericTypes => new[]
        {
            typeof(short),
            typeof(short?),
            typeof(int),
            typeof(int?),
            typeof(long),
            typeof(long?),
            typeof(ushort),
            typeof(ushort?),
            typeof(uint),
            typeof(uint?),
            typeof(ulong),
            typeof(ulong?),
            typeof(decimal),
            typeof(decimal?),
            typeof(double),
            typeof(double?),
            typeof(float),
            typeof(float?)
        };

        #region Constructors/Finalizer

        public Sage100IntegrationService(
            IMapper mapper,
            ILogger<Sage100IntegrationService> logger,
            IOptions<Sage100Options> sage100Options)
        {
            _mapper = mapper;
            _logger = logger;
            _sage100Options = sage100Options;
        }

        public Sage100IntegrationService(
            string programId,
            IMapper mapper,
            ILogger<Sage100IntegrationService> logger,
            IOptions<Sage100Options> sage100Options) : this(mapper, logger, sage100Options)
        {
            _type = Type.GetTypeFromProgID(programId, true);
            _instance = Activator.CreateInstance(_type);
        }

        public Sage100IntegrationService(
            string programId,
            string server,
            IMapper mapper,
            ILogger<Sage100IntegrationService> logger,
            IOptions<Sage100Options> sage100Options) : this(mapper, logger, sage100Options)
        {
            _type = Type.GetTypeFromProgID(programId, server, true);
            _instance = Activator.CreateInstance(_type);
        }

        public Sage100IntegrationService(
            Guid classId,
            IMapper mapper,
            ILogger<Sage100IntegrationService> logger,
            IOptions<Sage100Options> sage100Options) : this(mapper, logger, sage100Options)
        {
            _type = Type.GetTypeFromCLSID(classId, true);
            _instance = Activator.CreateInstance(_type);
        }

        public Sage100IntegrationService(
            Guid classId,
            string server,
            IMapper mapper,
            ILogger<Sage100IntegrationService> logger,
            IOptions<Sage100Options> sage100Options) : this(mapper, logger, sage100Options)
        {
            _type = Type.GetTypeFromCLSID(classId, server, true);
            _instance = Activator.CreateInstance(_type);
        }

        public Sage100IntegrationService(
            object @object,
            IMapper mapper,
            ILogger<Sage100IntegrationService> logger,
            IOptions<Sage100Options> sage100Options) : this(mapper, logger, sage100Options)
        {
            var typeHandle = Type.GetTypeHandle(@object);
            _type = Type.GetTypeFromHandle(typeHandle);
            _instance = @object;
        }

        ~Sage100IntegrationService()
        {
            Dispose();
        }

        #endregion

        public object InvokeMethodByRef(string name, object[] args)
        {
            var modifiers = new[] { GetParameterModifier(args.Length, true) };
            return _type.InvokeMember(name, InvokeFlags, null, _instance, args, modifiers, null, null);
        }

        public object InvokeMethod(string name, params object[] args)
        {
            return _type.InvokeMember(name, InvokeFlags, null, _instance, args);
        }

        public object InvokeMethod(string name, object[] args, ParameterModifier[] modifiers)
        {
            return _type.InvokeMember(name, InvokeFlags, null, _instance, args, modifiers, null, null);
        }

        public object GetProperty(string name)
        {
            return _type.InvokeMember(name, GetFlags, null, _instance, null);
        }

        public object SetProperty(string name, object value)
        {
            return _type.InvokeMember(name, SetFlags, null, _instance, new[] { value });
        }

        public object GetObject() => _instance;

        public void Dispose()
        {
            if (_instance == null) return;
            Marshal.ReleaseComObject(_instance);
            _instance = null;
            GC.SuppressFinalize(this);
        }

        public static ParameterModifier GetParameterModifier(int parameterCount, bool initialValue)
        {
            var mod = new ParameterModifier(parameterCount);
            for (var x = 0; x < parameterCount; x++) mod[x] = initialValue;
            return mod;
        }

        public Task<TModel[]> List<TModel, TRequest>(TRequest request, CancellationToken token)
            where TModel : class
        {
            if (!(request is ListRequest<TModel> sage100Request)) throw new ArgumentException("Invalid request");
            using (var provideX = GetProvideX())
            using (var session = GetSession(provideX))
            using (var busObj = provideX.GetBusObj(
                session: session,
                moduleName: sage100Request.ModuleName,
                programName: sage100Request.ProgramName,
                busObjName: sage100Request.BusObjName))
            {
                string[] keys;
                if (string.IsNullOrEmpty(sage100Request.KeyValue))
                {
                    keys = busObj.GetKeys(
                    compareDate: sage100Request.CompareDate,
                    descColumn: sage100Request.DefaultDescColumn,
                    keyColumn: sage100Request.KeyColumn,
                    filter: sage100Request.Filter,
                    begin: sage100Request.Begin,
                    end: sage100Request.End);
                }
                else
                {
                    keys = busObj.GetDetailKeys(
                    keyColumn: sage100Request.KeyColumn,
                    keyValue: sage100Request.KeyValue);
                }
                return Task.FromResult(busObj.GetRecords<TModel>(
                    descColumn: sage100Request.DescColumn,
                    keyColumn: sage100Request.KeyColumn,
                    keys: keys,
                    keyFilter: sage100Request.KeyFilter));
            }
        }

        public Task<TModel> Create<TModel, TRequest>(TRequest request, CancellationToken token)
            where TModel : class
        {
            if (!(request is CreateRequest<TModel> sage100Request)) throw new ArgumentException("Invalid request");
            using (var provideX = GetProvideX())
            using (var session = GetSession(provideX))
            using (var busObj = provideX.GetBusObj(
                session: session,
                moduleName: sage100Request.ModuleName,
                programName: sage100Request.ProgramName,
                busObjName: sage100Request.BusObjName))
            {
                var type = typeof(TModel);
                if (!type.IsAssignableFrom(typeof(Header<>)) || type.BaseType?.GenericTypeArguments?.Length != 1)
                {
                    return busObj.CreateRecord(sage100Request);
                }

                var genericType = type.BaseType.GenericTypeArguments[0];
                return (Task<TModel>)typeof(Sage100IntegrationService)
                    .GetMethod(nameof(SetHeader), BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.MakeGenericMethod(new[] { type, genericType })
                    .Invoke(this, new object[] { busObj, sage100Request });

            }
        }

        public Task<TModel> Read<TModel, TRequest>(TRequest request, CancellationToken token)
            where TModel : class
        {
            return Task.FromResult<TModel>(default);
        }

        public Task Update<TModel, TRequest>(TRequest request, CancellationToken token)
            where TModel : class
        {
            return Task.CompletedTask;
        }

        public Task Delete<TModel, TRequest>(TRequest request, CancellationToken token)
            where TModel : class
        {
            return Task.CompletedTask;
        }

        private Sage100IntegrationService GetBusObj(
            Sage100IntegrationService session,
            string moduleName,
            string programName,
            string busObjName)
        {
            session.InvokeMethod("nSetDate", moduleName, $"{DateTime.UtcNow.ToLocalTime():yyyyMMdd}");
            session.InvokeMethod("nSetModule", moduleName);
            var taskId = (int)session.InvokeMethod("nLookupTask", programName);
            session.InvokeMethod("nSetProgram", taskId);
            var busObj = InvokeMethod("NewObject", new[] { busObjName, session.GetObject() });
            return new Sage100IntegrationService(busObj, _mapper, _logger, _sage100Options);
        }

        private T GetRecord<T>(string record)
        {
            T GetRecord(string[] recordProperties) => Map<T>(recordProperties);

            var recordValues = record.Split(new[] { Record.Sep }, StringSplitOptions.None);
            if (recordValues.Length > 1) return GetRecord(recordValues);
            InvokeMethod("nSetKey", record);
            record = (string)InvokeMethod("nGetOrigRecord$");
            recordValues = record.Split('Š');
            return GetRecord(recordValues);
        }

        private Task<TModel> CreateRecord<TModel>(CreateRequest<TModel> sage100Request)
            where TModel : class
        {
            int result;
            string key;
            if (!string.IsNullOrEmpty(sage100Request.GetKeyName))
            {
                var nextKey = new object[] { string.Empty };
                result = (int)InvokeMethodByRef(sage100Request.GetKeyName, nextKey);
                VerifyResult(result);
                key = $"{nextKey[0]}";
            }
            else if (!string.IsNullOrEmpty(sage100Request.Key))
            {
                key = sage100Request.Key;
            }
            else
            {
                throw new Exception("Invalid key");
            }
            result = (int)InvokeMethod("nSetKey", key);
            VerifyResult(result, 2);
            WriteProperties(sage100Request.Model);
            return Task.FromResult(sage100Request.Model);
        }

        private Task<TModel> UpdateRecord<TModel>(UpdateRequest<TModel> sage100Request)
            where TModel : class
        {
            var result = (int)InvokeMethod("nSetKey", sage100Request.Key);
            VerifyResult(result);
            WriteProperties(sage100Request.Model);
            return Task.FromResult(sage100Request.Model);
        }

        private Task<THeader> SetHeader<THeader, TLine>(CreateRequest<THeader> sage100Request)
            where THeader : Header<TLine>
        {
            var nextSalesOrderNo = new object[] { string.Empty };
            var result = (int)InvokeMethodByRef(sage100Request.GetKeyName, nextSalesOrderNo);
            VerifyResult(result);
            result = (int)InvokeMethod("nSetKey", nextSalesOrderNo[0]);
            VerifyResult(result, 2);
            WriteProperties(sage100Request.Model, false);
            using (var oLines = new Sage100IntegrationService(GetProperty("oLines"), _mapper, _logger, _sage100Options))
            {
                foreach (var line in sage100Request.Model.Lines)
                {
                    result = (int)oLines.InvokeMethod("nAddLine");
                    oLines.VerifyResult(result, 2);
                    oLines.WriteProperties(line);
                }
            }

            result = (int)InvokeMethod("nWrite");
            VerifyResult(result);
            return Task.FromResult(sage100Request.Model);
        }

        private string[] GetKeys(
            DateTime? compareDate,
            string descColumn,
            string keyColumn,
            string filter,
            string begin,
            string end)
        {
            var args = new object[]
            {
                descColumn,
                keyColumn,
                string.Empty,
                string.Empty,
                filter,
                begin,
                end
            };
            InvokeMethodByRef("nGetResultSets", args);
            var dateTimes = $"{args[2]}".Split('Š');
            var keys = $"{args[3]}".Split('Š');
            var tuples = dateTimes
                .Zip(keys, (dateTime, key) => !string.IsNullOrEmpty(key) && !string.IsNullOrWhiteSpace(key)
                    ? Tuple.Create(dateTime, key)
                    : null)
                .Where(x => x != null)
                .ToArray();
            return compareDate.HasValue
                ? GetKeys(compareDate.Value, tuples)
                : keys.Where(x => !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x)).ToArray();
        }

        private T[] GetRecords<T>(
            string descColumn,
            string keyColumn,
            IReadOnlyCollection<string> keys,
            Func<string[], string, string> keyFilter)
        {
            List<T> GetRecordSet(string[] keySet)
            {
                var recordsList = new List<T>();
                var args = new object[]
                {
                    descColumn,
                    keyColumn,
                    string.Empty,
                    string.Empty,
                    keyFilter(keySet, keyColumn),
                    string.Empty,
                    string.Empty
                };

                InvokeMethodByRef("nGetResultSets", args);
                foreach (var result in $"{args[2]}"
                    .Split('Š')
                    .Where(x => !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x))
                    .Zip(keySet, Tuple.Create))
                {
                    InvokeMethod("nSetKey", result.Item2);
                    var record = GetRecord<T>(result.Item1);
                    if (record != null) recordsList.Add(record);
                }

                return recordsList;
            }

            const int take = 250;
            var records = new List<T>();
            var skip = 0;
            for (var i = 0; i < keys.Count / take; i++)
            {
                var keySet = keys.Skip(skip).Take(take).ToArray();
                var recordSet = GetRecordSet(keySet);
                records.AddRange(recordSet);
                skip += take;
            }

            if (keys.Count % take > 0)
            {
                var keySet = keys.Skip(skip).Take(take).ToArray();
                var recordSet = GetRecordSet(keySet);
                records.AddRange(recordSet);
            }

            return records.ToArray();
        }

        private string[] GetDetailKeys(
            string keyColumn,
            string keyValue)
        {
            var keys = new List<string>();
            var keyColumns = keyColumn.Split('+');
            InvokeMethod("nSetBrowseFilter", keyValue);
            InvokeMethod("nMoveFirst");
            var result = (string)InvokeMethod("nGetOrigRecord$");
            while (!string.IsNullOrEmpty(result) && (int)InvokeMethod("nEOF") != 1)
            {
                var fieldValues = result.Split('Š');
                var key = string.Empty;
                for (var i = 0; i < Math.Min(keyColumns.Length, fieldValues.Length); i++)
                {
                    key += fieldValues[i];
                }
                keys.Add(key);
                InvokeMethod("nMoveNext");
                result = (string)InvokeMethod("nGetOrigRecord$");
            }

            return keys.ToArray();
        }

        private T Map<T>(string[] properties)
        {
            try
            {
                return _mapper.Map<string[], T>(properties);
            }
            catch (AutoMapperMappingException e)
            {
                _logger.LogError(
                    exception: e,
                    message: "Error mapping values {@record} to type {@type}",
                    args: new object[] { properties, typeof(T).Name });
                throw;
            }
        }

        private Sage100IntegrationService GetProvideX()
        {
            var provideX = new Sage100IntegrationService("ProvideX.Script", _mapper, _logger, _sage100Options);
            provideX.InvokeMethod("Init", _sage100Options.Value.Path);
            return provideX;
        }

        private Sage100IntegrationService GetSession(Sage100IntegrationService provideX)
        {
            var sessionObj = provideX.InvokeMethod("NewObject", "SY_Session");
            var session = new Sage100IntegrationService(sessionObj, _mapper, _logger, _sage100Options);
            session.InvokeMethod("nSetUser", new object[]
            {
                _sage100Options.Value.Username,
                _sage100Options.Value.Password
            });
            session.InvokeMethod("nSetCompany", _sage100Options.Value.Company);
            return session;
        }

        private void VerifyResult(int result, int success = 1)
        {
            if (result == success) return;
            var error = $"{InvokeMethod("sLastErrorMsg")}";
            var exception = new Exception(error);
            _logger.LogError(
                exception: exception,
                message: "Sage 100 Error: {@error}",
                args: new object[] { error });
            throw exception;
        }

        private void WriteProperties<T>(T model, bool write = true)
        {
            int result;
            foreach (var property in typeof(T).GetWritableProperties(model))
            {
                result = (int)InvokeMethod("nSetValue", new[]
                {
                    NumericTypes.Contains(property.PropertyType) ? property.Name : $"{property.Name}$",
                    property.GetValue(model)
                });
                VerifyResult(result);
            }

            if (!write) return;
            result = (int)InvokeMethod("nWrite");
            VerifyResult(result);
        }

        private static string[] GetKeys(DateTime compareDate, IEnumerable<Tuple<string, string>> tuples)
        {
            var keys = new List<string>();
            foreach (var (dateTimes, key) in tuples)
            {
                if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key)) continue;
                var dateTimesArray = dateTimes.Split(',');
                if (dateTimesArray.Length != 4) continue;

                var yearMonthDay = dateTimesArray[0];
                var hourMinutes = decimal.Parse(dateTimesArray[1]);
                var date = FromSageValues(yearMonthDay, hourMinutes);
                if (date > compareDate)
                {
                    keys.Add(key);
                    continue;
                }

                yearMonthDay = dateTimesArray[2];
                hourMinutes = decimal.Parse(dateTimesArray[3]);
                date = FromSageValues(yearMonthDay, hourMinutes);
                if (date > compareDate)
                {
                    keys.Add(key);
                }
            }

            return keys.ToArray();
        }

        private static DateTime FromSageValues(string yearMonthDay, decimal hourMinutes)
        {
            var hour = Math.Floor(hourMinutes);
            var minutes = Math.Floor((hourMinutes - hour) * 60);
            var seconds = Math.Floor(((hourMinutes - hour) * 60 - minutes) * 60);
            return DateTime.ParseExact(
                s: $"{yearMonthDay} {hour:00.##}:{minutes:00.##}:{seconds:00.##}",
                format: "yyyyMMdd HH:mm:ss",
                provider: CultureInfo.InvariantCulture,
                style: DateTimeStyles.None);
        }
    }
}
