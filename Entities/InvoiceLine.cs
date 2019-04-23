namespace Clarity.Sage
{
    public abstract class InvoiceLine : Line
    {
        /// <summary>
        /// Invoice Number
        /// Read Only: Y
        /// FmtType: MASTERNUM
        /// </summary>
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Product Line
        /// FmtType: CHARNUM
        /// </summary>
        public string ProductLine { get; set; }

        /// <summary>
        /// Order Warehouse
        /// FmtType: CHARNUM
        /// </summary>
        public string OrderWarehouse { get; set; }

        /// <summary>
        /// Order Line Key
        /// Mask: 000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string OrderLineKey { get; set; }

        /// <summary>
        /// Extended Cost
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? ExtendedCost { get; set; }

        /// <summary>
        /// Extended Negative Quantity Adju
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? ExtendedNegQtyAdj { get; set; }

        /// <summary>
        /// Commission Amount
        /// Mask: ###,###,###.00
        /// Notes: (Calc @ Pre-Update)
        /// </summary>
        public decimal? CommissionAmt { get; set; }
    }
}
