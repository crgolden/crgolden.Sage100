namespace Clarity.Sage.SalesOrderHeaders
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;

    public abstract class SalesOrderHeaderFromSageRequestHandler<TRequest, TEntity, TLine> : RecordFromSageRequestHandler<TRequest, TEntity>
        where TRequest : SalesOrderHeaderFromSageRequest<TEntity, TLine>
        where TEntity : SalesOrderHeader<TLine>
        where TLine : SalesOrderDetail
    {
        protected override Func<
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
            > Selector => (d, c, m, l, r, s, o, t) => d.GetSalesOrderHeader<TEntity, TLine>(c, m, l, s, r, o, t);

        protected SalesOrderHeaderFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions) : base(mapper, context, logger, sageOptions)
        {
        }
    }
}
