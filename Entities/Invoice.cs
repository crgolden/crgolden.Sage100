namespace Clarity.Sage
{
    public abstract class Invoice<TLine> : Header<TLine>
        where TLine : InvoiceLine
    {
        /// <summary>
        /// Invoice Number
        /// FmtType: MASTERNUM
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Invoice Date
        /// DepVal: REQUIRED
        public string InvoiceDate { get; set; }

        /// <summary>
        /// Invoice Type
        /// Valid: CM, DM, IN, AD, FC, CA, XD
        /// Notes: CM = Credit Memo, DM = Debit Memo,
        /// IN = Invoice, AD = Adjustment,
        /// FC = Finance Charge, CA = Cash, XD = Deleted
        /// </summary>
        public char? InvoiceType { get; set; }

        /// <summary>
        /// Ship Date
        /// </summary>
        public string ShipDate { get; set; }

        /// <summary>
        /// Print Invoice
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PrintInvoice { get; set; }

        /// <summary>
        /// Invoice Printed
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? InvoicePrinted { get; set; }

        /// <summary>
        /// Accept Cash Only
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? AcceptCashOnly { get; set; }

        /// <summary>
        /// Customer Type
        /// </summary>
        public string CustomerType { get; set; }

        /// <summary>
        /// Apply To Invoice Number
        /// FmtType: CHARNUM
        /// DepVal:REQUIRED
        /// Notes: (For CM & Dm Types)
        /// </summary>
        public string ApplyToInvoiceNo { get; set; }

        /// <summary>
        /// Invoice Due Date
        /// </summary>
        public string InvoiceDueDate { get; set; }

        /// <summary>
        /// Discount Due Date
        /// </summary>
        public string DiscountDueDate { get; set; }

        /// <summary>
        /// Batch Number
        /// FmtType: ALPHANUM
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// E-Mail Update Flag for Restart
        /// </summary>
        public char? EMailUpdateFlagForRestart { get; set; }

        /// <summary>
        /// Order Changed In Shipping
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? OrderChangedInShipping { get; set; }

        /// <summary>
        /// Lines Changed In Shipping
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? LinesChangedInShipping { get; set; }

        /// <summary>
        /// Shipper ID
        /// </summary>
        public string ShipperID { get; set; }

        /// <summary>
        /// Ship Status
        /// Valid: N, L, S, D
        /// Notes: N = New, L = Lines completed, S = Shipped, D = Deleted
        /// </summary>
        public char? ShipStatus { get; set; }

        /// <summary>
        /// Starship Freight Used
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? StarshipFreightUsed { get; set; }

        /// <summary>
        /// Starship Records Created
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? StarshipRecordsCreated { get; set; }

        /// <summary>
        /// Invalid Warranty Code
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Set at Pre-Update
        /// </summary>
        public bool? InvalidWarrantyCode { get; set; }

        /// <summary>
        /// Retention Amount
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? RetentionAmt { get; set; }

        /// <summary>
        /// Total Subject To Commission
        /// Mask: ###,###,###.00
        /// Notes: (Calc @ Pre-Update)
        /// </summary>
        public decimal? TotalSubjectToComm { get; set; }

        /// <summary>
        /// Commission Amount
        /// Mask: ##,###,###.00-
        /// Notes: (Calc @ Pre-Update)
        /// </summary>
        public decimal? CommissionAmt { get; set; }

        /// <summary>
        /// Override Commission Amount
        /// Mask: ##,###,###.00-
        /// Notes: Calc @Pre-Update
        /// </summary>
        public decimal? OverrideCommAmt { get; set; }

        /// <summary>
        /// Cost Of Goods Sold Amount
        /// Mask: ###,###,###.00-
        /// Notes: (Calc @ Pre-Update)
        /// </summary>
        public decimal? CostOfGoodsSoldAmt { get; set; }

        /// <summary>
        /// Cost of Goods Sold Subject To C
        /// Mask: ###,###,###.00-
        /// Notes: Calc @ Pre-Update)
        /// </summary>
        public decimal? CostOfGoodsSoldSubjToComm { get; set; }

        /// <summary>
        /// SI Shipped Lines COGS
        /// Mask: ###,###,###.00-
        /// </summary>
        public decimal? SIShippedLinesCOGS { get; set; }

        /// <summary>
        /// Number Of C.O.D. Labels
        /// Mask: 00
        /// </summary>
        public int? NumberOfCODLabels { get; set; }

        /// <summary>
        /// Number Of Backordered Lines
        /// Mask: 00000
        /// Notes: (From Update)
        /// </summary>
        public int? NumberOfBackOrderLines { get; set; }

        /// <summary>
        /// Number of Packages
        /// Mask: 0000
        /// </summary>
        public int? NumberofPackages { get; set; }

        public new const string DefaultDesc = Header<TLine>.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "InvoiceNo$+\"" + Sep + "\"+" +                     // 93
            "InvoiceDate$+\"" + Sep + "\"+" +                   // 94
            "InvoiceType$+\"" + Sep + "\"+" +                   // 95
            "ShipDate$+\"" + Sep + "\"+" +                      // 96
            "PrintInvoice$+\"" + Sep + "\"+" +                  // 97
            "InvoicePrinted$+\"" + Sep + "\"+" +                // 98
            "AcceptCashOnly$+\"" + Sep + "\"+" +                // 99
            "CustomerType$+\"" + Sep + "\"+" +                  // 100
            "ApplyToInvoiceNo$+\"" + Sep + "\"+" +              // 101
            "InvoiceDueDate$+\"" + Sep + "\"+" +                // 102
            "DiscountDueDate$+\"" + Sep + "\"+" +               // 103
            "BatchNo$+\"" + Sep + "\"+" +                       // 104
            "EMailUpdateFlagForRestart$+\"" + Sep + "\"+" +     // 105
            "OrderChangedInShipping$+\"" + Sep + "\"+" +        // 106
            "LinesChangedInShipping$+\"" + Sep + "\"+" +        // 107
            "ShipperID$+\"" + Sep + "\"+" +                     // 108
            "ShipStatus$+\"" + Sep + "\"+" +                    // 109
            "StarshipFreightUsed$+\"" + Sep + "\"+" +           // 110
            "StarshipRecordsCreated$+\"" + Sep + "\"+" +        // 111
            "InvalidWarrantyCode$+\"" + Sep + "\"+" +           // 112
            "STR(RetentionAmt)+\"" + Sep + "\"+" +              // 113
            "STR(TotalSubjectToComm)+\"" + Sep + "\"+" +        // 114
            "STR(CommissionAmt)+\"" + Sep + "\"+" +             // 115
            "STR(OverrideCommAmt)+\"" + Sep + "\"+" +           // 116
            "STR(CostOfGoodsSoldAmt)+\"" + Sep + "\"+" +        // 117
            "STR(CostOfGoodsSoldSubjToComm)+\"" + Sep + "\"+" + // 118
            "STR(SIShippedLinesCOGS)+\"" + Sep + "\"+" +        // 119
            "STR(NumberOfCODLabels)+\"" + Sep + "\"+" +         // 120
            "STR(NumberOfBackOrderLines)+\"" + Sep + "\"+" +    // 121
            "STR(NumberofPackages)";                            // 122
    }
}
