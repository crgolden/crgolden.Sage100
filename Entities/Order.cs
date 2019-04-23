namespace Clarity.Sage
{
    public abstract class Order<TLine> : Header<TLine>
        where TLine : OrderLine
    {
        /// <summary>
        /// Master Repeating Order Number
        /// FmtType: CHARNUM
        /// </summary>
        public string MasterRepeatingOrderNo { get; set; }

        /// <summary>
        /// Ship Expire Date
        /// DepVal: REQUIRED
        /// </summary>
        public string ShipExpireDate { get; set; }

        /// <summary>
        /// Print Sales Orders
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PrintSalesOrders { get; set; }

        /// <summary>
        /// Sales Order Printed
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? SalesOrderPrinted { get; set; }

        /// <summary>
        /// Print Picking Sheets
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PrintPickingSheets { get; set; }

        /// <summary>
        /// Picking Sheet Printed
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PickingSheetPrinted { get; set; }

        /// <summary>
        /// Last Invoice Order Date
        /// </summary>
        public string LastInvoiceOrderDate { get; set; }

        /// <summary>
        /// Last Invoice Order Number
        /// FmtType: MASTERNUM
        /// </summary>
        public string LastInvoiceOrderNo { get; set; }

        /// <summary>
        /// Current Invoice Number
        /// FmtType: MASTERNUM
        /// </summary>
        public string CurrentInvoiceNo { get; set; }

        /// <summary>
        /// Cycle Code
        /// FmtType: CHARNUM
        /// </summary>
        public string CycleCode { get; set; }

       /// <summary>
        /// Cancellation Reason Code
        /// FmtType: CHARNUM
        /// </summary>
        public string CancelReasonCode { get; set; }

        /// <summary>
        /// CRM Prospect ID
        /// </summary>
        public string CRMProspectID { get; set; }

        public new const string DefaultDesc = Header<TLine>.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "MasterRepeatingOrderNo$+\"" + Sep + "\"+" +    // 93
            "ShipExpireDate$+\"" + Sep + "\"+" +            // 94
            "PrintSalesOrders$+\"" + Sep + "\"+" +          // 95
            "SalesOrderPrinted$+\"" + Sep + "\"+" +         // 96
            "PrintPickingSheets$+\"" + Sep + "\"+" +        // 97
            "PickingSheetPrinted$+\"" + Sep + "\"+" +       // 98
            "LastInvoiceOrderDate$+\"" + Sep + "\"+" +      // 99
            "LastInvoiceOrderNo$+\"" + Sep + "\"+" +        // 100
            "CurrentInvoiceNo$+\"" + Sep + "\"+" +          // 101
            "CycleCode$+\"" + Sep + "\"+" +                 // 102
            "CancelReasonCode$+\"" + Sep + "\"+" +          // 103
            "CRMProspectID$";                               // 104
    }
}
