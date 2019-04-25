namespace Clarity.Sage.Orders
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public abstract class OrderFromSageRequestHandler<TRequest, THeader, TLine> : HeaderFromSageRequestHandler<TRequest, THeader, TLine>
        where TRequest : OrderFromSageRequest<THeader, TLine>
        where THeader : Order<TLine>
        where TLine : OrderLine
    {
        protected new static string[] LineColumns => new[]
        {
            "SalesOrderNo$",            // 67
            "MasterOrderLineKey$",      // 68
            "PrintDropShipment$",       // 69
            "MasterOriginalQty",        // 70
            "MasterQtyBalance",         // 71
            "MasterQtyOrderedToDate",   // 72
            "RepeatingQtyShippedToDate" // 73
        };

        protected override Func<
            SageBoiService,
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
            > SetLines => (d, h, c, m, l, s, r, o, t) => d.SetOrderLines<THeader, TLine>(h, c, m, l, s, r, o, t);

        protected OrderFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions) : base(mapper, context, logger, sageOptions)
        {
        }
    }
}
