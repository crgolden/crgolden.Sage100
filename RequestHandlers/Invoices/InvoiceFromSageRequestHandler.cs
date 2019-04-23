namespace Clarity.Sage.Invoices
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public abstract class InvoiceFromSageRequestHandler<TRequest, THeader, TLine> : HeaderFromSageRequestHandler<TRequest, THeader, TLine>
        where TRequest : InvoiceFromSageRequest<THeader, TLine>
        where THeader : Invoice<TLine>
        where TLine : InvoiceLine
    {
        protected new static string[] LineColumns => new[]
        {
            "InvoiceNo$",           // 67
            "ProductLine$",         // 68
            "OrderWarehouse$",      // 69
            "OrderLineKey$",        // 70
            "ExtendedCost",         // 71
            "ExtendedNegQtyAdj",    // 72
            "CommissionAmt"         // 73
        };

        protected override Func<
            DispatchObject,
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
            > SetLines => (d, h, c, m, l, s, r, o, t) => d.SetInvoiceLines<THeader, TLine>(h, c, m, l, s, r, o, t);

        protected InvoiceFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions) : base(mapper, context, logger, sageOptions)
        {
        }
    }
}
