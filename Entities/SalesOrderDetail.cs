namespace crgolden.Sage
{
    public abstract class SalesOrderDetail
    {
        /// <summary>
        /// Sales Order Number
        /// Read Only: Y
        /// FmtType: CHARNUM
        /// </summary>
        public string SalesOrderNo { get; set; }

        /// <summary>
        /// Line Key
        /// Read Only: Y
        /// Mask:000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string LineKey { get; set; }

        /// <summary>
        /// Line Sequence Number
        /// Read Only: Y
        /// Mask: 00000000000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string LineSeqNo { get; set; }

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
        public ItemTypes ItemType { get; set; }

        /// <summary>
        /// Item Code Description
        /// </summary>
        public string ItemCodeDesc { get; set; }

        /// <summary>
        /// Extended Description Key
        /// Read Only :Y
        /// </summary>
        public string ExtendedDescriptionKey { get; set; }

        /// <summary>
        /// Discount
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? Discount { get; set; } = false;

        /// <summary>
        /// Commissionable
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? Commissionable { get; set; } = false;

        /// <summary>
        /// Subject To Exemption
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? SubjectToExemption { get; set; } = false;

        /// <summary>
        /// Warehouse Code
        /// FmtType: CHARNUM
        /// </summary>
        public string WarehouseCode { get; set; }

        /// <summary>
        /// Valuation
        /// Valid: 1, 2, 3, 4, 5, 6
        /// Notes: 1 = Standard, 2 = Average, 3 = Fifo, 4 = Lifo,
        /// 5 = Lot, 6 = Serial
        /// </summary>
        public Valuations? Valuation { get; set; }

        /// <summary>
        /// Price Level
        /// DepVal: REQUIRED
        /// </summary>
        public char? PriceLevel { get; set; }

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

        /// <summary>
        /// Drop Ship
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? DropShip { get; set; } = false;

        /// <summary>
        /// Lot/Serial Fully Distributed
        /// DfltVal: Y
        /// Valid: Y, N
        /// </summary>
        public bool? LotSerialFullyDistributed { get; set; } = true;

        /// <summary>
        /// Print Drop Shipment
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PrintDropShipment { get; set; } = false;

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
        public bool? PriceOverridden { get; set; } = false;

        /// <summary>
        /// Exploded Kit Item
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? ExplodedKitItem { get; set; } = false;

        /// <summary>
        /// Standard/Kit Bill
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? StandardKitBill { get; set; } = false;

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
        public bool? BackorderKitCompLine { get; set; } = false;

        /// <summary>
        /// Skip Printing Of This Component
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Line In S/O
        /// </summary>
        public bool? SkipPrintCompLine { get; set; } = false;

        /// <summary>
        /// Promise Date
        /// </summary>
        public string PromiseDate { get; set; }

        /// <summary>
        /// Alias Item Number
        /// </summary>
        public string AliasItemNo { get; set; }

        /// <summary>
        /// Sales Order History Detail Sequ
        /// Mask: 00000000000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string SOHistoryDetlSeqNo { get; set; }

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
        public char? CustomerAction { get; set; } = 'N';

        /// <summary>
        /// Item Action
        /// DfltVal: N
        /// Valid: N, S, P, R
        /// Notes: N = None, S = Stock, P = scraP, R = Repair
        /// </summary>
        public char? ItemAction { get; set; } = 'N';

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
        public bool? ExpirationOverridden { get; set; } = false;

        /// <summary>
        /// Cost Overridden
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? CostOverridden { get; set; } = false;

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
        public char? CostType { get; set; }

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
        /// Quantity Ordered
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? QuantityOrdered { get; set; }

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
        /// Master Original Quantity
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? MasterOriginalQty { get; set; }

        /// <summary>
        /// Master Quantity Balance
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? MasterQtyBalance { get; set; }

        /// <summary>
        /// Master Quantity Ordered To Date
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? MasterQtyOrderedToDate { get; set; }

        /// <summary>
        /// Repeating Quantity Shipped To D
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? RepeatingQtyShippedToDate { get; set; }

        /// <summary>
        /// Unit Price
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Unit Cost
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// Extension Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? ExtensionAmt { get; set; }

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
        public decimal? LineWeight { get; set; }

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
        /// Notes: Always false (N); Per SPS, when true this
        /// indicates sales tax included in ExtendedItemAmount
        /// </summary>
        public bool? NetGrossIndicator { get; set; } = false;

        /// <summary>
        /// Debit Credit Indicator
        /// DfltVal: C
        /// Valid: D, C
        /// Notes: Per SPS, Always 'C'reditcard
        /// </summary>
        public char? DebitCreditIndicator { get; set; } = 'C';

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
    }
}
