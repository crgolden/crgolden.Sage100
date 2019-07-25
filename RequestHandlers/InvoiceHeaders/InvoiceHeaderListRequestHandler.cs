namespace crgolden.Sage100.InvoiceHeaders
{
    using System.Collections.Generic;
    using Shared;

    public abstract class InvoiceHeaderListRequestHandler<TRequest, THeader, TLine> : ListRequestHandler<TRequest, THeader>
        where TRequest : InvoiceHeaderListRequest<THeader, TLine>
        where THeader : InvoiceHeader<TLine>
        where TLine : InvoiceDetail
    {
        protected static string[] LineColumns => new[]
        {
            "InvoiceNo$",                   // 00
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
            "ProductLine$",                 // 11
            "Valuation$",                   // 12
            "PriceLevel$",                  // 13
            "UnitOfMeasure$",               // 14
            "DropShip$",                    // 15
            "LotSerialFullyDistributed$",   // 16
            "SalesKitLineKey$",             // 17
            "CostOfGoodsSoldAcctKey$",      // 18
            "SalesAcctKey$",                // 19
            "PriceOverridden$",             // 20
            "OrderWarehouse$",              // 21
            "ExplodedKitItem$",             // 22
            "OrderLineKey$",                // 23
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
            "StandardKitBill$",             // 35
            "SkipPrintCompLine$",           // 36
            "AliasItemNo$",                 // 37
            "TaxClass$",                    // 38
            "SOHistoryDetlSeqNo$",          // 39
            "CustomerAction$",              // 40
            "WarrantyCode$",                // 41
            "ExpirationDate$",              // 42
            "ExpirationOverridden$",        // 43
            "CostOverridden$",              // 44
            "ItemAction$",                  // 45
            "CostCode$",                    // 46
            "CostType$",                    // 47
            "CommentText$",                 // 48
            "PromiseDate$",                 // 49
            "APDivisionNo$",                // 50
            "VendorNo$",                    // 51
            "PurchaseOrderNo$",             // 52
            "PurchaseOrderRequiredDate$",   // 53
            "QuantityOrdered",              // 54
            "QuantityShipped",              // 55
            "QuantityBackordered",          // 56
            "UnitPrice",                    // 57
            "ExtensionAmt",                 // 58
            "ExtendedCost",                 // 59
            "ExtendedNegQtyAdj",            // 60
            "UnitCost",                     // 61
            "UnitOfMeasureConvFactor",      // 62
            "CommissionAmt",                // 63
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
        //    > SetLines => (d, h, c, m, l, s, r, o, t) => d.SetInvoiceHeaderLines<THeader, TLine>(h, c, m, l, s, r, o, t);

        protected abstract string[] GetLineColumns();

        protected InvoiceHeaderListRequestHandler(IEnumerable<IIntegrationService> integrationServices) : base(integrationServices)
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
