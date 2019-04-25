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

    public abstract class HeaderFromSageRequestHandler<TRequest, THeader, TLine> : RecordFromSageRequestHandler<TRequest, THeader>
        where TRequest : RecordFromSageRequest<THeader>
        where THeader : Header<TLine>
        where TLine : Line
    {
        protected static string[] LineColumns => new[]
        {
            "LineKey$",                     // 00
            "LineSeqNo$",                   // 01
            "ItemCode$",                    // 02
            "ItemType$",                    // 03
            "ItemCodeDesc$",                // 04
            "ExtendedDescriptionKey$",      // 05
            "Discount$",                    // 06
            "Commissionable$",              // 07
            "SubjectToExemption$",          // 08
            "WarehouseCode$",               // 09
            "PriceLevel$",                  // 10
            "Valuation$",                   // 11
            "UnitOfMeasure$",               // 12
            "DropShip$",                    // 13
            "LotSerialFullyDistributed$",   // 14
            "SalesKitLineKey$",             // 15
            "CostOfGoodsSoldAcctKey$",      // 16
            "SalesAcctKey$",                // 17
            "PriceOverridden$",             // 18
            "ExplodedKitItem$",             // 19
            "StandardKitBill$",             // 20
            "Revision$",                    // 21
            "BillOption1$",                 // 22
            "BillOption2$",                 // 23
            "BillOption3$",                 // 24
            "BillOption4$",                 // 25
            "BillOption5$",                 // 26
            "BillOption6$",                 // 27
            "BillOption7$",                 // 28
            "BillOption8$",                 // 29
            "BillOption9$",                 // 30
            "BackorderKitCompLine$",        // 31
            "SkipPrintCompLine$",           // 32
            "AliasItemNo$",                 // 33
            "TaxClass$",                    // 34
            "SOHistoryDetlSeqNo$",          // 35
            "CustomerAction$",              // 36
            "ItemAction$",                  // 37
            "WarrantyCode$",                // 38
            "ExpirationDate$",              // 39
            "ExpirationOverridden$",        // 40
            "CostOverridden$",              // 41
            "CostCode$",                    // 42
            "CostType$",                    // 43
            "CommentText$",                 // 44
            "PromiseDate$",                 // 45
            "QuantityOrdered",              // 46
            "QuantityShipped",              // 47
            "QuantityBackordered",          // 48
            "UnitPrice",                    // 49
            "UnitCost",                     // 50
            "ExtensionAmt",                 // 51
            "UnitOfMeasureConvFactor",      // 52
            "QuantityPerBill",              // 53
            "LineDiscountPercent",          // 54
            "APDivisionNo$",                // 55
            "VendorNo$",                    // 56
            "PurchaseOrderNo$",             // 57
            "PurchaseOrderRequiredDate$",   // 58
            "LineWeight",                   // 59
            "CommodityCode$",               // 60
            "AlternateTaxIdentifier$",      // 61
            "TaxTypeApplied$",              // 62
            "NetGrossIndicator$",           // 63
            "DebitCreditIndicator$",        // 64
            "TaxAmt",                       // 65
            "TaxRate"                       // 66
        };

        protected new Func<
            SageBoiService,
            DbContext,
            IMapper,
            ILogger,
            string,
            EntityState,
            string[],
            Func<
                DbContext,
                string[],
                EntityState,
                CancellationToken,
                Task<Action<IMappingOperationOptions>>
                >[],
            CancellationToken,
            Task<THeader>
            > Selector => (d, c, m, l, r, s, lc, o, t) => d.GetHeader<THeader, TLine>(c, m, l, s, r, lc, o, t, SetLines);

        protected abstract Func<
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
            > SetLines { get; }

        protected abstract string[] GetLineColumns();

        protected HeaderFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions) : base(mapper, context, logger, sageOptions)
        {
        }

        public override async Task<Unit> Handle(TRequest request, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            var records = await GetRecords(
                request: request,
                selector: (d, r, s, t) => Selector(d, Context, Mapper, Logger, r, s, GetLineColumns(), Opts, t),
                token: token).ConfigureAwait(false);
            if (records?.Count > 0) await Context.ProcessAsync(records, token).ConfigureAwait(false);
            return Unit.Value;
        }
    }
}
