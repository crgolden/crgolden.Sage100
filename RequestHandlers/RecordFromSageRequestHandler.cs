namespace Clarity.Sage
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;

    public abstract class RecordFromSageRequestHandler<TRequest, TEntity> : IRequestHandler<TRequest>
        where TRequest : RecordFromSageRequest<TEntity>
        where TEntity : Record
    {
        protected readonly IMapper Mapper;
        protected readonly DbContext Context;
        protected readonly ILogger Logger;
        protected readonly SageOptions SageOptions;

        protected virtual Func<
            DispatchObject,
            DbContext,
            IMapper,
            ILogger,
            string,
            EntityState,
            Func<
                DbContext,
                string[],
                EntityState,
                CancellationToken,
                Task<Action<IMappingOperationOptions>>
                >[],
            CancellationToken,
            Task<TEntity>
            > Selector => (d, c, m, l, r, s, o, t) => d.GetRecord<TEntity>(c, m, l, s, r, o, t);

        protected virtual Func<
            IEnumerable<string>,
            string,
            string
            > KeyFilter => (keys, keyColumn) => $"{keyColumn}=\"{string.Join($"\" OR {keyColumn}=\"", keys)}\"";

        protected abstract Func<
            DbContext,
            string[],
            EntityState,
            CancellationToken,
            Task<Action<IMappingOperationOptions>>
            >[] Opts { get; }

        protected RecordFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions)
        {
            Mapper = mapper;
            Context = context;
            Logger = logger;
            SageOptions = sageOptions.Value;
        }

        public virtual async Task<Unit> Handle(TRequest request, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            Dictionary<EntityState, TEntity[]> records;
            using (var provideX = new DispatchObject("ProvideX.Script"))
            {
                provideX.InvokeMethod("Init", SageOptions.Path);
                using (var session = new DispatchObject(provideX.InvokeMethod("NewObject", "SY_Session")))
                {
                    session.InvokeMethod("nSetUser", SageOptions.Username, SageOptions.Password);
                    session.InvokeMethod("nSetCompany", SageOptions.Company);
                    using (var busObj = provideX.GetBusObj(session, request.ModuleName, request.ProgramName, request.BusObjName))
                    {
                        records = await busObj.GetGroupedRecords(
                            compareDate: request.CompareDate,
                            selector: (r, s) => Selector(busObj, Context, Mapper, Logger, r, s, Opts, token),
                            groupedKeysDescColumn: request.DefaultDescColumn,
                            recordsDescColumn: request.DescColumn,
                            keyColumn: request.KeyColumn,
                            filter: request.Filter,
                            begin: request.Begin,
                            end: request.End,
                            keyFilter: KeyFilter).ConfigureAwait(false);
                    };
                }
            }

            if (records?.Count > 0) await Context.ProcessAsync(records, token).ConfigureAwait(false);
            return Unit.Value;
        }
    }
}
