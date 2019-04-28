namespace Clarity.Sage.SalesOrderHeaders
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

    public abstract class SalesOrderHeaderFromSageRequestHandler<TRequest, THeader, TLine> : RecordFromSageRequestHandler<TRequest, THeader>
        where TRequest : SalesOrderHeaderFromSageRequest<THeader, TLine>
        where THeader : SalesOrderHeader<TLine>
        where TLine : SalesOrderDetail
    {
        protected static string[] LineColumns => new[]
        {
            "SalesOrderNo$",                // 00
            "LineKey$",                     // 01
            "LineSeqNo$",                   // 02
            "ItemCode$",                    // 03
            "ItemType$",                    // 04
            "ItemCodeDesc$",                // 05
            "ExtendedDescriptionKey$",      // 06
            "Discount$",                    // 07
            "Commissionable$",              // 08
            "SubjectToExemption$",          // 09
            "WarehouseCode$",               // 10
            "Valuation$",                   // 11
            "PriceLevel$",                  // 12
            "MasterOrderLineKey$",          // 13
            "UnitOfMeasure$",               // 14
            "DropShip$",                    // 15
            "LotSerialFullyDistributed$",   // 16
            "PrintDropShipment$",           // 17
            "SalesKitLineKey$",             // 18
            "CostOfGoodsSoldAcctKey$",      // 19
            "SalesAcctKey$",                // 20
            "PriceOverridden$",             // 21
            "ExplodedKitItem$",             // 22
            "StandardKitBill$",             // 23
            "Revision$",                    // 24
            "BillOption1$",                 // 25
            "BillOption2$",                 // 26
            "BillOption3$",                 // 27
            "BillOption4$",                 // 28
            "BillOption5$",                 // 29
            "BillOption6$",                 // 30
            "BillOption7$",                 // 31
            "BillOption8$",                 // 32
            "BillOption9$",                 // 33
            "BackorderKitCompLine$",        // 34
            "SkipPrintCompLine$",           // 35
            "PromiseDate$",                 // 36
            "AliasItemNo$",                 // 37
            "SOHistoryDetlSeqNo$",          // 38
            "TaxClass$",                    // 39
            "CustomerAction$",              // 40
            "ItemAction$",                  // 41
            "WarrantyCode$",                // 42
            "ExpirationDate$",              // 43
            "ExpirationOverridden$",        // 44
            "CostOverridden$",              // 45
            "CostCode$",                    // 46
            "CostType$",                    // 47
            "CommentText$",                 // 48
            "APDivisionNo$",                // 49
            "VendorNo$",                    // 50
            "PurchaseOrderNo$",             // 51
            "PurchaseOrderRequiredDate$",   // 52
            "QuantityOrdered",              // 53
            "QuantityShipped",              // 54
            "QuantityBackordered",          // 55
            "MasterOriginalQty",            // 56
            "MasterQtyBalance",             // 57
            "MasterQtyOrderedToDate",       // 58
            "RepeatingQtyShippedToDate",    // 59
            "UnitPrice",                    // 60
            "UnitCost",                     // 61
            "ExtensionAmt",                 // 62
            "UnitOfMeasureConvFactor",      // 63
            "QuantityPerBill",              // 64
            "LineDiscountPercent",          // 65
            "LineWeight",                   // 66
            "CommodityCode$",               // 67
            "AlternateTaxIdentifier$",      // 68
            "TaxTypeApplied$",              // 69
            "NetGrossIndicator$",           // 70
            "DebitCreditIndicator$",        // 71
            "TaxAmt",                       // 72
            "TaxRate"                       // 73
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
        //    > SetLines => (d, h, c, m, l, s, r, o, t) => d.SetSalesOrderHeaderLines<THeader, TLine>(h, c, m, l, s, r, o, t);

        protected abstract string[] GetLineColumns();

        protected SalesOrderHeaderFromSageRequestHandler(
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
