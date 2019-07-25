namespace crgolden.Sage100
{
    public abstract class PurchaseOrderDetail
    {
        /// <summary>
        /// Purchase Order Number
        /// Read Only: Y
        /// </summary>
        public string PurchaseOrderNo { get; set; }

        /// <summary>
        /// Line Key
        /// Read Only: Y
        /// Mask: 000000
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
        /// Extended Description Key
        /// Read Only: Y
        /// </summary>
        public string ExtendedDescriptionKey { get; set; }

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
        /// Use Tax
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string UseTax { get; set; } = "N";

        /// <summary>
        /// Required Date
        /// </summary>
        public string RequiredDate { get; set; }

        /// <summary>
        /// Vendor Price Code
        /// Read Only: Y
        /// </summary>
        public string VendorPriceCode { get; set; }

        /// <summary>
        /// Purchases Account Key
        /// DepVal: REQUIRED
        /// </summary>
        public string PurchasesAcctKey { get; set; }

        /// <summary>
        /// Valuation
        /// Read Only: Y
        /// Valid: 1, 2, 3, 4, 5, 6
        /// Notes: 1 = Standard, 2 = Average, 3 = Fifo, 4 = Lifo,
        /// 5 = Lot, 6 = Serial
        /// </summary>
        public string Valuation { get; set; }

        /// <summary>
        /// Unit Of Measure
        /// DepVal: REQUIRED
        /// </summary>
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Warehouse Code
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string WarehouseCode { get; set; }

        /// <summary>
        /// Product Line
        /// Read Only: Y
        /// FmtType: CHARNUM
        /// </summary>
        public string ProductLine { get; set; }

        /// <summary>
        /// Master Line Key
        /// Mask: 000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string MasterLineKey { get; set; }

        /// <summary>
        /// Reschedule
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Dflt: N (If Mrp Integrated)
        /// </summary>
        public string Reschedule { get; set; } = "N";

        /// <summary>
        /// Job Number
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string JobNo { get; set; }

        /// <summary>
        /// Cost Code
        /// DepVal: REQUIRED
        /// </summary>
        public string CostCode { get; set; }

        /// <summary>
        /// Cost Type
        /// DepVal: REQUIRED
        /// </summary>
        public string CostType { get; set; }

        /// <summary>
        /// Receipt Of Goods Updated
        /// Read Only: Y
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string ReceiptOfGoodsUpdated { get; set; } = "N";

        /// <summary>
        /// Work Order Number
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string WorkOrderNo { get; set; }

        /// <summary>
        /// Step Number
        /// DepVal: REQUIRED
        /// </summary>
        public string StepNo { get; set; }

        /// <summary>
        /// Sub-Step Prefix
        /// DepVal: REQUIRED
        /// </summary>
        public string SubStepPrefix { get; set; }

        /// <summary>
        /// Sub-Step Suffix
        /// DepVal: REQUIRED
        /// </summary>
        public string SubStepSuffix { get; set; }

        /// <summary>
        /// Work Order Type
        /// DepVal: REQUIRED
        /// </summary>
        public string WorkOrderType { get; set; }

        /// <summary>
        /// Allocate Landed Cost
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string AllocateLandedCost { get; set; } = "N";

        /// <summary>
        /// Vendor Alias Item Number
        /// </summary>
        public string VendorAliasItemNo { get; set; }

        /// <summary>
        /// Tax Class
        /// DepVal: REQUIRED
        /// </summary>
        public string TaxClass { get; set; }

        /// <summary>
        /// Comment Text
        /// DepVal: REQUIRED
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        /// Asset Account
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string AssetAccount { get; set; } = "N";

        /// <summary>
        /// Asset Template
        /// DepVal: REQUIRED
        /// </summary>
        public string AssetTemplate { get; set; }

        /// <summary>
        /// Weight Reference
        /// </summary>
        public string WeightReference { get; set; }

        /// <summary>
        /// Sales Order Number
        /// FmtType: CHARNUM
        /// </summary>
        public string SalesOrderNo { get; set; }

        /// <summary>
        /// Customer PO Number
        /// </summary>
        public string CustomerPONo { get; set; }

        /// <summary>
        /// Weight
        /// Mask: #####.0000-
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Quantity Ordered
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? QuantityOrdered { get; set; }

        /// <summary>
        /// Quantity Received
        /// Read Only: Y
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? QuantityReceived { get; set; }

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
        /// Read Only: Y
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? MasterQtyBalance { get; set; }

        /// <summary>
        /// Master Quantity Ordered To Date
        /// Read Only: Y
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? MasterQtyOrderedToDate { get; set; }

        /// <summary>
        /// Quantity Invoiced
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? QuantityInvoiced { get; set; }

        /// <summary>
        /// Unit Cost
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// Original Unit Cost
        /// Read Only: Y
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? OriginalUnitCost { get; set; }

        /// <summary>
        /// Extension Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? ExtensionAmt { get; set; }

        /// <summary>
        /// Received Amount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? ReceivedAmt { get; set; }

        /// <summary>
        /// Invoiced Amount
        /// Read Only: Y
        /// Mask:###,###,###.00
        /// </summary>
        public decimal? InvoicedAmt { get; set; }

        /// <summary>
        /// Unit Of Measure Conversion Fact
        /// Mask: #####0.0000
        /// </summary>
        public decimal? UnitOfMeasureConvFactor { get; set; }

        /// <summary>
        /// Received Allocated Amount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? ReceivedAllocatedAmt { get; set; }

        /// <summary>
        /// Invoiced Allocated Amount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? InvoicedAllocatedAmt { get; set; }
    }
}
