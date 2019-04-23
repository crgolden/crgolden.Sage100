namespace Clarity.Sage
{
    public abstract class OrderLine : Line
    {
        /// <summary>
        /// Sales Order Number
        /// Read Only: Y
        /// FmtType: CHARNUM
        /// </summary>
        public string SalesOrderNo { get; set; }

        /// <summary>
        /// Master Order Line Key
        /// Mask: 000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string MasterOrderLineKey { get; set; }

        /// <summary>
        /// Print Drop Shipment
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PrintDropShipment { get; set; }

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
    }
}
