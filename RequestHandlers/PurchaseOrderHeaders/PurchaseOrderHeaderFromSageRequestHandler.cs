namespace crgolden.Sage.PurchaseOrderHeaders
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;

    public abstract class PurchaseOrderHeaderFromSageRequestHandler<TRequest, THeader, TLine> : RecordFromSageRequestHandler<TRequest, THeader>
        where TRequest : PurchaseOrderHeaderFromSageRequest<THeader, TLine>
        where THeader : PurchaseOrderHeader<TLine>
        where TLine : PurchaseOrderDetail
    {
        protected static string[] LineColumns => new[]
        {
            "PurchaseOrderNo$",         // 00
            "LineKey$",                 // 01
            "LineSeqNo$",               // 02
            "ItemCode$",                // 03
            "ExtendedDescriptionKey$",  // 04
            "ItemType$",                // 05
            "ItemCodeDesc$",            // 06
            "UseTax$",                  // 07
            "RequiredDate$",            // 08
            "VendorPriceCode$",         // 09
            "PurchasesAcctKey$",        // 10
            "Valuation$",               // 11
            "UnitOfMeasure$",           // 12
            "WarehouseCode$",           // 13
            "ProductLine$",             // 14
            "MasterLineKey$",           // 15
            "Reschedule$",              // 16
            "JobNo$",                   // 17
            "CostCode$",                // 18
            "CostType$",                // 19
            "ReceiptOfGoodsUpdated$",   // 20
            "WorkOrderNo$",             // 21
            "StepNo$",                  // 22
            "SubStepPrefix$",           // 23
            "SubStepSuffix$",           // 24
            "WorkOrderType$",           // 25
            "AllocateLandedCost$",      // 26
            "VendorAliasItemNo$",       // 27
            "TaxClass$",                // 28
            "CommentText$",             // 29
            "AssetAccount$",            // 30
            "AssetTemplate$",           // 31
            "WeightReference$",         // 32
            "SalesOrderNo$",            // 33
            "CustomerPONo$",            // 34
            "Weight",                   // 35
            "QuantityOrdered",          // 36
            "QuantityReceived",         // 37
            "QuantityBackordered",      // 38
            "MasterOriginalQty",        // 39
            "MasterQtyBalance",         // 40
            "MasterQtyOrderedToDate",   // 41
            "QuantityInvoiced",         // 42
            "UnitCost",                 // 43
            "OriginalUnitCost",         // 44
            "ExtensionAmt",             // 45
            "ReceivedAmt",              // 46
            "InvoicedAmt",              // 47
            "UnitOfMeasureConvFactor",  // 48
            "ReceivedAllocatedAmt",     // 49
            "InvoicedAllocatedAmt"      // 50
        };

        //protected new Func<
        //    SageBoiService,
        //    DbContext,
        //    IMapper,
        //    ILogger,
        //    string,
        //    EntityState,
        //    string[],
        //    Func<
        //        DbContext,
        //        string[],
        //        EntityState,
        //        CancellationToken,
        //        Task<Action<IMappingOperationOptions>>
        //        >[],
        //    CancellationToken,
        //    Task<THeader>
        //    > Selector => (d, c, m, l, r, s, lc, o, t) => d.GetHeader<THeader, TLine>(c, m, l, s, r, lc, o, t, SetLines);

        //protected override Func<
        //    SageBoiService,
        //    THeader,
        //    DbContext,
        //    IMapper,
        //    ILogger,
        //    EntityState,
        //    string[],
        //    Func<DbContext,
        //        string[],
        //        EntityState,
        //        CancellationToken,
        //        Task<Action<IMappingOperationOptions>>>,
        //    CancellationToken,
        //    Task
        //    > SetLines => (d, h, c, m, l, s, r, o, t) => d.SetInvoiceLines<THeader, TLine>(h, c, m, l, s, r, o, t);

        protected abstract string[] GetLineColumns();

        protected PurchaseOrderHeaderFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions) : base(mapper, context, logger, sageOptions)
        {
        }

        //public override async Task<Unit> Handle(TRequest request, CancellationToken token)
        //{
        //    token.ThrowIfCancellationRequested();
        //    var records = await GetRecords(
        //        request: request,
        //        selector: (d, r, s, t) => Selector(d, Context, Mapper, Logger, r, s, GetLineColumns(), Opts, t),
        //        token: token).ConfigureAwait(false);
        //    if (records?.Count > 0) await Context.ProcessAsync(records, token).ConfigureAwait(false);
        //    return Unit.Value;
        //}
    }
}
