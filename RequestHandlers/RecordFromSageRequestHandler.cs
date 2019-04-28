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
            BoiService,
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
            var records = await GetRecords(
                request: request,
                selector: (d, r, s, t) => Selector(d, Context, Mapper, Logger, r, s, Opts, t),
                token: token).ConfigureAwait(false);
            if (records?.Count > 0) await Context.ProcessAsync(records, token).ConfigureAwait(false);
            return Unit.Value;
        }

        protected virtual async Task<Dictionary<EntityState, TEntity[]>> GetRecords(
            TRequest request,
            Func<BoiService, string, EntityState, CancellationToken, Task<TEntity>> selector,
            CancellationToken token)
        {
            using (var provideX = GetProvideX())
            using (var session = GetSession(provideX))
            using (var busObj = provideX.GetBusObj(session, request.ModuleName, request.ProgramName, request.BusObjName))
            return await busObj.GetGroupedRecords(
                compareDate: request.CompareDate,
                context: Context,
                selector: (d, r, s, t) => selector(d, r, s, t),
                groupedKeysDescColumn: request.DefaultDescColumn,
                recordsDescColumn: request.DescColumn,
                keyColumn: request.KeyColumn,
                filter: request.Filter,
                begin: request.Begin,
                end: request.End,
                keyFilter: KeyFilter,
                token: token).ConfigureAwait(false);
        }

        protected virtual BoiService GetProvideX()
        {
            var provideX = new BoiService("ProvideX.Script");
            provideX.InvokeMethod("Init", SageOptions.Path);
            return provideX;
        }

        protected virtual BoiService GetSession(BoiService provideX)
        {
            var session = new BoiService(provideX.InvokeMethod("NewObject", "SY_Session"));
            session.InvokeMethod("nSetUser", SageOptions.Username, SageOptions.Password);
            session.InvokeMethod("nSetCompany", SageOptions.Company);
            return session;
        }
    }
}
