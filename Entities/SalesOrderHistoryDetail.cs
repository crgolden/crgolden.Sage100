namespace crgolden.Sage100
{
    using System.ComponentModel;

    public abstract class SalesOrderHistoryDetail
    {
        /// <summary>
        /// Sales Order Number
        /// Read Only: Y
        /// FmtType: CHARNUM
        /// </summary>
        [ReadOnly(true)]
        public string SalesOrderNo { get; set; }

        /// <summary>
        /// Sequence Number
        /// Read Only: Y
        /// Mask: 00000000000000
        /// FmtType: ZEROFILL
        /// </summary>
        [ReadOnly(true)]
        public string SequenceNo { get; set; }

        /// <summary>
        /// Line Key
        /// Read Only: Y
        /// Mask:000000
        /// FmtType: ZEROFILL
        /// </summary>
        [ReadOnly(true)]
        public string LineKey { get; set; }

        /// <summary>
        /// Original Line
        /// </summary>
        public string OriginalLine { get; set; }

        /// <summary>
        /// Cancelled Line
        /// </summary>
        public string CancelledLine { get; set; }

        /// <summary>
        /// Cancel Reason Code
        /// </summary>
        public string CancelReasonCode { get; set; }

        /// <summary>
        /// Item Code
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// ItemType
        /// Valid: 1, 2, 3, 4, 5
        /// Notes: 1 = Regular Item, 2 = Special Item, 3 = Charge Item,
        /// 4 = Comment Item, 5 = Miscellaneous Item
        /// </summary>
        public string ItemType { get; set; }

        /// <summary>
        /// Item Code Description
        /// </summary>
        public string ItemCodeDesc { get; set; }

        /// <summary>
        /// Extended Description Key
        /// Read Only :Y
        /// </summary>
        [ReadOnly(true)]
        public string ExtendedDescriptionKey { get; set; }

        /// <summary>
        /// Discount
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string Discount { get; set; } = "N";

        /// <summary>
        /// Commissionable
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string Commissionable { get; set; } = "N";

        /// <summary>
        /// Subject To Exemption
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string SubjectToExemption { get; set; } = "N";

        /// <summary>
        /// Warehouse Code
        /// FmtType: CHARNUM
        /// </summary>
        public string WarehouseCode { get; set; }

        /// <summary>
        /// Price Level
        /// DepVal: REQUIRED
        /// </summary>
        public string PriceLevel { get; set; }

        /// <summary>
        /// Drop Ship
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string DropShip { get; set; } = "N";

        /// <summary>
        /// Print Drop Shipment
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string PrintDropShipment { get; set; } = "N";

        /// <summary>
        /// Master Order Line Key
        /// Mask: 000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string MasterOrderLineKey { get; set; }

        /// <summary>
        /// Unit Of Measure
        /// </summary>
        public string UnitOfMeasure { get; set; }

        /// Sales Kit Line Key
        /// Mask: 000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string SalesKitLineKey { get; set; }

        /// <summary>
        /// <summary>
        /// Cost of Goods Sold Account Key
        /// DepVal: REQUIRED
        /// </summary>
        public string CostOfGoodsSoldAcctKey { get; set; }

        /// <summary>
        /// Sales Account Key
        /// DepVal: REQUIRED
        /// </summary>
        public string SalesAcctKey { get; set; }

        /// <summary>
        /// Has Price Been Overridden
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string PriceOverridden { get; set; } = "N";

        /// <summary>
        /// Exploded Kit Item
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string ExplodedKitItem { get; set; } = "N";

        /// <summary>
        /// Standard/Kit Bill
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string StandardKitBill { get; set; } = "N";

        /// <summary>
        /// Bill Revision Code
        /// </summary>
        public string Revision { get; set; }

        /// <summary>
        /// Bill Option 1
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string BillOption1 { get; set; }

        /// <summary>
        /// Bill Option 2
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string BillOption2 { get; set; }

        /// <summary>
        /// Bill Option 3
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string BillOption3 { get; set; }

        /// <summary>
        /// Bill Option 4
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string BillOption4 { get; set; }

        /// <summary>
        /// Bill Option 5
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string BillOption5 { get; set; }

        /// <summary>
        /// Bill Option 6
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string BillOption6 { get; set; }

        /// <summary>
        /// Bill Option 7
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string BillOption7 { get; set; }

        /// <summary>
        /// Bill Option 8
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string BillOption8 { get; set; }

        /// <summary>
        /// Bill Option 9
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string BillOption9 { get; set; }

        /// <summary>
        /// Backorder Kit Component Line
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Kit Bckord = 0, Comp Bckord > 0 Flg = Y
        /// </summary>
        public string BackorderKitCompLine { get; set; } = "N";

        /// <summary>
        /// Skip Printing Of This Component
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Line In S/O
        /// </summary>
        public string SkipPrintCompLine { get; set; } = "N";

        /// <summary>
        /// Promise Date
        /// </summary>
        public string PromiseDate { get; set; }

        /// <summary>
        /// Alias Item Number
        /// </summary>
        public string AliasItemNo { get; set; }

        /// <summary>
        /// Tax Class
        /// </summary>
        public string TaxClass { get; set; }

        /// <summary>
        /// Customer Action
        /// DfltVal: N
        /// Valid: N, C, P, R
        /// Notes: N = None, C = Credit, P = rePlacement, R = Repair
        /// </summary>
        public string CustomerAction { get; set; } = "N";

        /// <summary>
        /// Item Action
        /// DfltVal: N
        /// Valid: N, S, P, R
        /// Notes: N = None, S = Stock, P = scraP, R = Repair
        /// </summary>
        public string ItemAction { get; set; } = "N";

        /// <summary>
        /// Warranty Code
        /// DepVal: REQUIRED
        /// </summary>
        public string WarrantyCode { get; set; }

        /// <summary>
        /// Expiration Date
        /// </summary>
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Expiration Overridden
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string ExpirationOverridden { get; set; } = "N";

        /// <summary>
        /// Cost Overridden
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string CostOverridden { get; set; } = "N";

        /// <summary>
        /// Cost Code
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string CostCode { get; set; }

        /// <summary>
        /// Cost Type
        /// DepVal: REQUIRED
        /// </summary>
        public string CostType { get; set; }

        /// <summary>
        /// Comment Text
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        /// AP Division Number
        /// Mask: 00
        /// DepVal: REQUIRED
        /// </summary>
        public string APDivisionNo { get; set; }

        /// <summary>
        /// Vendor Number
        /// FmtType: MASTERNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string VendorNo { get; set; }

        /// <summary>
        /// Purchase Order Number
        /// FmtType: CHARNUM
        /// </summary>
        public string PurchaseOrderNo { get; set; }

        /// <summary>
        /// Purchase Order Required Date
        /// </summary>
        public string PurchaseOrderRequiredDate { get; set; }

        /// <summary>
        /// Commodity Code
        /// </summary>
        public string CommodityCode { get; set; }

        /// <summary>
        /// Alternate Tax Identifier
        /// </summary>
        public string AlternateTaxIdentifier { get; set; }

        /// <summary>
        /// Tax Type Applied
        /// </summary>
        public string TaxTypeApplied { get; set; }

        /// <summary>
        /// Net Gross Indicator
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Always "N" (N); Per SPS, when true this
        /// indicates sales tax included in ExtendedItemAmount
        /// </summary>
        public string NetGrossIndicator { get; set; } = "N";

        /// <summary>
        /// Debit Credit Indicator
        /// DfltVal: C
        /// Valid: D, C
        /// Notes: Per SPS, Always 'C'reditcard
        /// </summary>
        public string DebitCreditIndicator { get; set; } = "C";

        /// <summary>
        /// Quantity Ordered Original
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? QuantityOrderedOriginal { get; set; }

        /// <summary>
        /// Quantity Ordered Revised
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? QuantityOrderedRevised { get; set; }

        /// <summary>
        /// Quantity Shipped
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? QuantityShipped { get; set; }

        /// <summary>
        /// Quantity Backordered
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? QuantityBackordered { get; set; }

        /// <summary>
        /// Original Unit Price
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? OriginalUnitPrice { get; set; }

        /// <summary>
        /// Last Unit Price
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? LastUnitPrice { get; set; }

        /// <summary>
        /// Last Extension Amount
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? LastExtensionAmt { get; set; }

        /// <summary>
        /// Unit Cost
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// Unit Of Measure Conversion Fact
        /// Mask: #####0.0000
        /// </summary>
        public decimal? UnitOfMeasureConvFactor { get; set; }

        /// <summary>
        /// Quantity Per Bill
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? QuantityPerBill { get; set; }

        /// <summary>
        /// Line Discount Percent
        /// Mask: #,##0.000-
        /// </summary>
        public decimal? LineDiscountPercent { get; set; }

        /// <summary>
        /// Line Weight
        /// Read Only: Y
        /// Mask: ##,###,###.00-
        /// </summary>
        [ReadOnly(true)]
        public decimal? LineWeight { get; set; }

        /// <summary>
        /// Tax Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? TaxAmt { get; set; }

        /// <summary>
        /// Tax Rate
        /// Mask: ###.000000-
        /// Valid: 0-999.999999
        /// </summary>
        public decimal? TaxRate { get; set; }

        [ReadOnly(true)]
        public const string Sep = "_,_";

        public const string DefaultDesc =
            "SalesOrderNo$+\"" + Sep + "\"+" +                  // 00
            "SequenceNo$+\"" + Sep + "\"+" +                    // 01
            "LineKey$+\"" + Sep + "\"+" +                       // 02
            "OriginalLine$+\"" + Sep + "\"+" +                  // 03
            "CancelledLine$+\"" + Sep + "\"+" +                 // 04
            "CancelReasonCode$+\"" + Sep + "\"+" +              // 05
            "ItemCode$+\"" + Sep + "\"+" +                      // 06
            "ItemType$+\"" + Sep + "\"+" +                      // 07
            "ItemCodeDesc$+\"" + Sep + "\"+" +                  // 08
            "ExtendedDescriptionKey$+\"" + Sep + "\"+" +        // 09
            "Discount$+\"" + Sep + "\"+" +                      // 10
            "Commissionable$+\"" + Sep + "\"+" +                // 11
            "SubjectToExemption$+\"" + Sep + "\"+" +            // 12
            "WarehouseCode$+\"" + Sep + "\"+" +                 // 13
            "PriceLevel$+\"" + Sep + "\"+" +                    // 14
            "DropShip$+\"" + Sep + "\"+" +                      // 15
            "PrintDropShipment$+\"" + Sep + "\"+" +             // 16
            "MasterOrderLineKey$+\"" + Sep + "\"+" +            // 17
            "UnitOfMeasure$+\"" + Sep + "\"+" +                 // 18
            "SalesKitLineKey$+\"" + Sep + "\"+" +               // 19
            "CostOfGoodsSoldAcctKey$+\"" + Sep + "\"+" +        // 20
            "SalesAcctKey$+\"" + Sep + "\"+" +                  // 21
            "PriceOverridden$+\"" + Sep + "\"+" +               // 22
            "ExplodedKitItem$+\"" + Sep + "\"+" +               // 23
            "StandardKitBill$+\"" + Sep + "\"+" +               // 24
            "Revision$+\"" + Sep + "\"+" +                      // 25
            "BillOption1$+\"" + Sep + "\"+" +                   // 26
            "BillOption2$+\"" + Sep + "\"+" +                   // 27
            "BillOption3$+\"" + Sep + "\"+" +                   // 28
            "BillOption4$+\"" + Sep + "\"+" +                   // 29
            "BillOption5$+\"" + Sep + "\"+" +                   // 30
            "BillOption6$+\"" + Sep + "\"+" +                   // 31
            "BillOption7$+\"" + Sep + "\"+" +                   // 32
            "BillOption8$+\"" + Sep + "\"+" +                   // 33
            "BillOption9$+\"" + Sep + "\"+" +                   // 34
            "BackorderKitCompLine$+\"" + Sep + "\"+" +          // 35
            "SkipPrintCompLine$+\"" + Sep + "\"+" +             // 36
            "PromiseDate$+\"" + Sep + "\"+" +                   // 37
            "AliasItemNo$+\"" + Sep + "\"+" +                   // 38
            "TaxClass$+\"" + Sep + "\"+" +                      // 39
            "CustomerAction$+\"" + Sep + "\"+" +                // 40
            "ItemAction$+\"" + Sep + "\"+" +                    // 41
            "WarrantyCode$+\"" + Sep + "\"+" +                  // 42
            "ExpirationDate$+\"" + Sep + "\"+" +                // 43
            "ExpirationOverridden$+\"" + Sep + "\"+" +          // 44
            "CostOverridden$+\"" + Sep + "\"+" +                // 45
            "CostCode$+\"" + Sep + "\"+" +                      // 46
            "CostType$+\"" + Sep + "\"+" +                      // 47
            "CommentText$+\"" + Sep + "\"+" +                   // 48
            "APDivisionNo$+\"" + Sep + "\"+" +                  // 49
            "VendorNo$+\"" + Sep + "\"+" +                      // 50
            "PurchaseOrderNo$+\"" + Sep + "\"+" +               // 51
            "PurchaseOrderRequiredDate$+\"" + Sep + "\"+" +     // 52
            "CommodityCode$+\"" + Sep + "\"+" +                 // 53
            "AlternateTaxIdentifier$+\"" + Sep + "\"+" +        // 54
            "TaxTypeApplied$+\"" + Sep + "\"+" +                // 55
            "NetGrossIndicator$+\"" + Sep + "\"+" +             // 56
            "DebitCreditIndicator$+\"" + Sep + "\"+" +          // 57
            "STR(QuantityOrderedOriginal)+\"" + Sep + "\"+" +   // 58
            "STR(QuantityOrderedRevised)+\"" + Sep + "\"+" +    // 59
            "STR(QuantityShipped)+\"" + Sep + "\"+" +           // 60
            "STR(QuantityBackordered)+\"" + Sep + "\"+" +       // 61
            "STR(OriginalUnitPrice)+\"" + Sep + "\"+" +         // 62
            "STR(LastUnitPrice)+\"" + Sep + "\"+" +             // 63
            "STR(LastExtensionAmt)+\"" + Sep + "\"+" +          // 64
            "STR(UnitCost)+\"" + Sep + "\"+" +                  // 65
            "STR(UnitOfMeasureConvFactor)+\"" + Sep + "\"+" +   // 66
            "STR(QuantityPerBill)+\"" + Sep + "\"+" +           // 67
            "STR(LineDiscountPercent)+\"" + Sep + "\"+" +       // 68
            "STR(LineWeight)+\"" + Sep + "\"+" +                // 69
            "STR(TaxAmt)+\"" + Sep + "\"+" +                    // 70
            "STR(TaxRate)";                                     // 71
    }
}
