namespace Clarity.Sage
{
    using System.Collections.Generic;

    public abstract class InvoiceHeader<TLine> : Record
        where TLine : InvoiceDetail
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
        public string InvoiceType { get; set; }

        /// <summary>
        /// Sales Order Number
        /// FmtType: CHARNUM
        /// </summary>
        public string SalesOrderNo { get; set; }

        /// <summary>
        /// Order Type
        /// DfltVal: 1
        /// Valid: B, S, 1
        /// Notes: B = Backorder, S = Standard, 1 = Step
        /// </summary>
        public char? OrderType { get; set; } = '1';

        /// <summary>
        /// Order Status
        /// DfltVal: N
        /// Valid: N, O, C, H
        /// Notes: N = New, O = Open, C = Closed, H = Hold
        /// </summary>
        public char? OrderStatus { get; set; }

        /// <summary>
        /// Order Date
        /// DepVal: REQUIRED
        /// </summary>
        public string OrderDate { get; set; }

        /// <summary>
        /// AR Division Number
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// </summary>
        public string ARDivisionNo { get; set; }

        /// <summary>
        /// Customer Number
        /// FmtType: MASTERNUMC
        /// </summary>
        public string CustomerNo { get; set; }

        /// <summary>
        /// Bill To Division Number
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// </summary>
        public string BillToDivisionNo { get; set; }

        /// <summary>
        /// Bill To Customer Number
        /// FmtType: MASTERNUMC
        /// DepVal: REQUIRED
        /// </summary>
        public string BillToCustomerNo { get; set; }

        /// <summary>
        /// Bill To Name
        /// </summary>
        public string BillToName { get; set; }

        /// <summary>
        /// Bill To Address Line 1
        /// </summary>
        public string BillToAddress1 { get; set; }

        /// <summary>
        /// Bill To Address Line 2
        /// </summary>
        public string BillToAddress2 { get; set; }

        /// <summary>
        /// Bill To Address Line 3
        /// </summary>
        public string BillToAddress3 { get; set; }

        /// <summary>
        /// Bill To City
        /// </summary>
        public string BillToCity { get; set; }

        /// <summary>
        /// Bill To State
        /// </summary>
        public string BillToState { get; set; }

        /// <summary>
        /// Bill To Zip Code
        /// </summary>
        public string BillToZipCode { get; set; }

        /// <summary>
        /// Bill To Country Code
        /// </summary>
        public string BillToCountryCode { get; set; }

        /// <summary>
        /// Ship-To Code
        /// </summary>
        public string ShipToCode { get; set; }

        /// <summary>
        /// Ship To Name
        /// </summary>
        public string ShipToName { get; set; }

        /// <summary>
        /// Ship To Address Line 1
        /// </summary>
        public string ShipToAddress1 { get; set; }

        /// <summary>
        /// Ship To Address Line 2
        /// </summary>
        public string ShipToAddress2 { get; set; }

        /// <summary>
        /// Ship To Address Line 3
        /// </summary>
        public string ShipToAddress3 { get; set; }

        /// <summary>
        /// Ship To City
        /// </summary>
        public string ShipToCity { get; set; }

        /// <summary>
        /// Ship To State
        /// </summary>
        public string ShipToState { get; set; }

        /// <summary>
        /// Ship To Zip Code
        /// </summary>
        public string ShipToZipCode { get; set; }

        /// <summary>
        /// Ship To Country Code
        /// </summary>
        public string ShipToCountryCode { get; set; }

        /// <summary>
        /// Ship Date
        /// </summary>
        public string ShipDate { get; set; }

        /// <summary>
        /// Ship Via
        /// </summary>
        public string ShipVia { get; set; }

        /// <summary>
        /// Ship Zone
        /// Notes: (Maintained)
        /// </summary>
        public string ShipZone { get; set; }

        /// <summary>
        /// Ship Zone Actual
        /// Notes: (Inverse If Shp As Zip)
        /// </summary>
        public string ShipZoneActual { get; set; }

        /// <summary>
        /// Ship Weight
        /// Mask: 00000
        /// FmtType: ZEROFILL
        /// </summary>
        public string ShipWeight { get; set; }

        /// <summary>
        /// Customer PO Number
        /// </summary>
        public string CustomerPONo { get; set; }

        /// <summary>
        /// F.O.B.
        /// </summary>
        public string FOB { get; set; }

        /// <summary>
        /// Warehouse Code
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string WarehouseCode { get; set; }

        /// <summary>
        /// Confirm To
        /// DepVal: REQUIRED
        /// </summary>
        public string ConfirmTo { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Tax Schedule
        /// FmtType: CHARNUM
        /// DepVal:REQUIRED
        /// </summary>
        public string TaxSchedule { get; set; }

        /// <summary>
        /// Terms Code
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// DepVal: REQUIRED
        /// </summary>
        public string TermsCode { get; set; }

        /// <summary>
        /// Tax Exempt Number
        /// Notes: (Only If Sales Tax Reporting = Yes)
        /// </summary>
        public string TaxExemptNo { get; set; }

        /// <summary>
        /// Print Invoice
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PrintInvoice { get; set; } = false;

        /// <summary>
        /// Invoice Printed
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? InvoicePrinted { get; set; } = false;

        /// <summary>
        /// Accept Cash Only
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? AcceptCashOnly { get; set; } = false;

        /// <summary>
        /// Customer Type
        /// </summary>
        public string CustomerType { get; set; }

        /// <summary>
        /// Residential Address
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? ResidentialAddress { get; set; } = false;

        /// <summary>
        /// Invalid Tax Calculation
        /// DfltVal :N
        /// Valid: Y, N
        /// </summary>
        public bool? InvalidTaxCalc { get; set; } = false;

        /// <summary>
        /// Freight Calculation Method
        /// Valid: A, P, W
        /// Notes: A = Amount, P = Product line, W = Weight
        /// </summary>
        public char? FreightCalculationMethod { get; set; }

        /// <summary>
        /// Check Number For Deposit
        /// FmtType: CHARNUM DepVal:REQUIRED
        /// </summary>
        public string CheckNoForDeposit { get; set; }

        /// <summary>
        /// Apply To Invoice Number
        /// FmtType: CHARNUM
        /// DepVal:REQUIRED
        /// Notes: (For CM & Dm Types)
        /// </summary>
        public string ApplyToInvoiceNo { get; set; }

        /// <summary>
        /// Lot/Serial Lines Exist
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? LotSerialLinesExist { get; set; } = false;

        /// <summary>
        /// Salesperson Division Number
        /// FmtType: ZEROFILL
        /// </summary>
        public string SalespersonDivisionNo { get; set; }

        /// <summary>
        /// Salesperson Number
        /// FmtType: CHARNUM
        /// </summary>
        public string SalespersonNo { get; set; }

        /// <summary>
        /// Split Commissions
        /// DfltVal: N
        /// Valid: Y, N, O
        /// Notes: Y = Yes, N = No, O = Override
        /// </summary>
        public char? SplitCommissions { get; set; } = 'N';

        /// <summary>
        /// Salesperson Division Number 2
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// </summary>
        public string SalespersonDivisionNo2 { get; set; }

        /// <summary>
        /// Salesperson Number 2
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string SalespersonNo2 { get; set; }

        /// <summary>
        /// Salesperson Division Number 3
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// </summary>
        public string SalespersonDivisionNo3 { get; set; }

        /// <summary>
        /// Salesperson Number 3
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string SalespersonNo3 { get; set; }

        /// <summary>
        /// Salesperson Division Number 4
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// </summary>
        public string SalespersonDivisionNo4 { get; set; }

        /// <summary>
        /// Salesperson Number 4
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string SalespersonNo4 { get; set; }

        /// <summary>
        /// Salesperson Division Number 5
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// </summary>
        public string SalespersonDivisionNo5 { get; set; }

        /// <summary>
        /// Salesperson Number 5
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string SalespersonNo5 { get; set; }

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
        /// eBusiness Manager Submission Ty
        /// Read Only: Y
        /// Valid: M, A
        /// Notes: M = Manual, A = Auto
        /// </summary>
        public char? EBMSubmissionType { get; set; }

        /// <summary>
        /// EBM Internet User ID Submitttin
        /// Read Only: Y
        /// </summary>
        public string EBMUserIDSubmittingThisOrder { get; set; }

        /// <summary>
        /// EBM Internet User Type
        /// Valid: 1, 2
        /// Notes: (1 = bus, 2 = consumer)
        /// </summary>
        public EBMUserTypes? EBMUserType { get; set; }

        /// <summary>
        /// E-Mail Update Flag for Restart
        /// </summary>
        public char? EMailUpdateFlagForRestart { get; set; }

        /// <summary>
        /// Fax Number
        /// DepVal: REQUIRED
        /// </summary>
        public string FaxNo { get; set; }

        /// <summary>
        /// Batch Fax
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? BatchFax { get; set; } = false;

        /// <summary>
        /// Batch Email
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? BatchEmail { get; set; } = false;

        /// <summary>
        /// Email Address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Payment Type
        /// DepVal: REQUIRED
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// Other Payment Type Reference Nu
        /// DepVal: REQUIRED
        /// </summary>
        public string OtherPaymentTypeRefNo { get; set; }

        /// <summary>
        /// Payment Type Category
        /// DfltVal: D
        /// Valid: P, D
        /// Notes: P = Payment, D = Deposit
        /// </summary>
        public char? PaymentTypeCategory { get; set; } = 'D';

        /// <summary>
        /// Order Changed In Shipping
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? OrderChangedInShipping { get; set; } = false;

        /// <summary>
        /// Lines Changed In Shipping
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? LinesChangedInShipping { get; set; } = false;

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
        public bool? StarshipFreightUsed { get; set; } = false;

        /// <summary>
        /// Starship Records Created
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? StarshipRecordsCreated { get; set; } = false;

        /// <summary>
        /// Job Number
        /// FmtType: CHARNUM
        /// DepVal:REQUIRED
        /// </summary>
        public string JobNo { get; set; }

        /// <summary>
        /// RMA Number
        /// FmtType: CHARNUM
        /// </summary>
        public string RMANo { get; set; }

        /// <summary>
        /// CRM User ID
        /// </summary>
        public string CRMUserID { get; set; }

        /// <summary>
        /// CRM Company ID
        /// </summary>
        public string CRMCompanyID { get; set; }

        /// <summary>
        /// CRM Person ID
        /// </summary>
        public string CRMPersonID { get; set; }

        /// <summary>
        /// CRM Opportunity ID
        /// </summary>
        public string CRMOpportunityID { get; set; }

        /// <summary>
        /// Invalid Warranty Code
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Set at Pre-Update
        /// </summary>
        public bool? InvalidWarrantyCode { get; set; } = false;

        /// <summary>
        /// Taxable Subject To Discount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? TaxableSubjectToDiscount { get; set; }

        /// <summary>
        /// Non-Taxable Subject To Discount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? NonTaxableSubjectToDiscount { get; set; }

        /// <summary>
        /// Tax-Subj-To-Disc % Of Total-Sub
        /// Read Only: Y
        /// Mask: ##0.00
        /// </summary>
        public decimal? TaxSubjToDiscPrcntOfTotSubjTo { get; set; }

        /// <summary>
        /// Discount Rate
        /// Mask: ##0.000
        /// </summary>
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// Taxable Amount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? TaxableAmt { get; set; }

        /// <summary>
        /// Non-Taxable Amount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? NonTaxableAmt { get; set; }

        /// <summary>
        /// Sales Tax Amount
        /// Read Only: Y
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? SalesTaxAmt { get; set; }

        /// <summary>
        /// Discount Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? DiscountAmt { get; set; }

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
        /// Commission Rate
        /// Mask: ###0.000
        /// </summary>
        public decimal? CommissionRate { get; set; }

        /// <summary>
        /// Commission Amount
        /// Mask: ##,###,###.00-
        /// Notes: (Calc @ Pre-Update)
        /// </summary>
        public decimal? CommissionAmt { get; set; }

        /// <summary>
        /// Split Commission Rate 2
        /// Mask: ###0.000
        /// </summary>
        public decimal? SplitCommRate2 { get; set; }

        /// <summary>
        /// Split Commission Rate 3
        /// Mask: ###0.000
        /// </summary>
        public decimal? SplitCommRate3 { get; set; }

        /// <summary>
        /// Split Commission Rate 4
        /// Mask: ###0.000
        /// </summary>
        public decimal? SplitCommRate4 { get; set; }

        /// <summary>
        /// Split Commission Rate 5
        /// Mask: ###0.000
        /// </summary>
        public decimal? SplitCommRate5 { get; set; }

        /// <summary>
        /// Override Commission Amount
        /// Mask: ##,###,###.00-
        /// Notes: Calc @Pre-Update
        /// </summary>
        public decimal? OverrideCommAmt { get; set; }

        /// <summary>
        /// Freight Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? FreightAmt { get; set; }

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
        /// Deposit Amount
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? DepositAmt { get; set; }

        /// <summary>
        /// Weight
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? Weight { get; set; }

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
        /// Number Of Shipping Labels
        /// Mask: 00
        /// </summary>
        public int? NumberOfShippingLabels { get; set; }

        /// <summary>
        /// Last Number Of Shipping Labels
        /// Mask: 00
        /// </summary>
        public int? LastNoOfShippingLabels { get; set; }

        /// <summary>
        /// Number of Packages
        /// Mask: 0000
        /// </summary>
        public int? NumberofPackages { get; set; }

        public virtual ICollection<TLine> Lines { get; set; } = new HashSet<TLine>();

        public new const string DefaultDesc = Record.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "InvoiceNo$+\"" + Sep + "\"+" +                         // 06
            "InvoiceDate$+\"" + Sep + "\"+" +                       // 07
            "InvoiceType$+\"" + Sep + "\"+" +                       // 08
            "SalesOrderNo$+\"" + Sep + "\"+" +                      // 09
            "OrderType$+\"" + Sep + "\"+" +                         // 10
            "OrderStatus$+\"" + Sep + "\"+" +                       // 11
            "OrderDate$+\"" + Sep + "\"+" +                         // 12
            "ARDivisionNo$+\"" + Sep + "\"+" +                      // 13
            "CustomerNo$+\"" + Sep + "\"+" +                        // 14
            "BillToDivisionNo$+\"" + Sep + "\"+" +                  // 15
            "BillToCustomerNo$+\"" + Sep + "\"+" +                  // 16
            "BillToName$+\"" + Sep + "\"+" +                        // 17
            "BillToAddress1$+\"" + Sep + "\"+" +                    // 18
            "BillToAddress2$+\"" + Sep + "\"+" +                    // 19
            "BillToAddress3$+\"" + Sep + "\"+" +                    // 20
            "BillToCity$+\"" + Sep + "\"+" +                        // 21
            "BillToState$+\"" + Sep + "\"+" +                       // 22
            "BillToZipCode$+\"" + Sep + "\"+" +                     // 23
            "BillToCountryCode$+\"" + Sep + "\"+" +                 // 24
            "ShipToCode$+\"" + Sep + "\"+" +                        // 25
            "ShipToName$+\"" + Sep + "\"+" +                        // 26
            "ShipToAddress1$+\"" + Sep + "\"+" +                    // 27
            "ShipToAddress2$+\"" + Sep + "\"+" +                    // 28
            "ShipToAddress3$+\"" + Sep + "\"+" +                    // 29
            "ShipToCity$+\"" + Sep + "\"+" +                        // 30
            "ShipToState$+\"" + Sep + "\"+" +                       // 31
            "ShipToZipCode$+\"" + Sep + "\"+" +                     // 32
            "ShipToCountryCode$+\"" + Sep + "\"+" +                 // 33
            "ShipDate$+\"" + Sep + "\"+" +                          // 34
            "ShipVia$+\"" + Sep + "\"+" +                           // 35
            "ShipZone$+\"" + Sep + "\"+" +                          // 36
            "ShipZoneActual$+\"" + Sep + "\"+" +                    // 37
            "ShipWeight$+\"" + Sep + "\"+" +                        // 38
            "CustomerPONo$+\"" + Sep + "\"+" +                      // 39
            "FOB$+\"" + Sep + "\"+" +                               // 40
            "WarehouseCode$+\"" + Sep + "\"+" +                     // 41
            "ConfirmTo$+\"" + Sep + "\"+" +                         // 42
            "Comment$+\"" + Sep + "\"+" +                           // 43
            "TaxSchedule$+\"" + Sep + "\"+" +                       // 44
            "TermsCode$+\"" + Sep + "\"+" +                         // 45
            "TaxExemptNo$+\"" + Sep + "\"+" +                       // 46
            "PrintInvoice$+\"" + Sep + "\"+" +                      // 47
            "InvoicePrinted$+\"" + Sep + "\"+" +                    // 48
            "AcceptCashOnly$+\"" + Sep + "\"+" +                    // 49
            "CustomerType$+\"" + Sep + "\"+" +                      // 50
            "ResidentialAddress$+\"" + Sep + "\"+" +                // 51
            "InvalidTaxCalc$+\"" + Sep + "\"+" +                    // 52
            "FreightCalculationMethod$+\"" + Sep + "\"+" +          // 53
            "CheckNoForDeposit$+\"" + Sep + "\"+" +                 // 54
            "ApplyToInvoiceNo$+\"" + Sep + "\"+" +                  // 55
            "LotSerialLinesExist$+\"" + Sep + "\"+" +               // 56
            "SalespersonDivisionNo$+\"" + Sep + "\"+" +             // 57
            "SalespersonNo$+\"" + Sep + "\"+" +                     // 58
            "SplitCommissions$+\"" + Sep + "\"+" +                  // 59
            "SalespersonDivisionNo2$+\"" + Sep + "\"+" +            // 60
            "SalespersonNo2$+\"" + Sep + "\"+" +                    // 61
            "SalespersonDivisionNo3$+\"" + Sep + "\"+" +            // 62
            "SalespersonNo3$+\"" + Sep + "\"+" +                    // 63
            "SalespersonDivisionNo4$+\"" + Sep + "\"+" +            // 64
            "SalespersonNo4$+\"" + Sep + "\"+" +                    // 65
            "SalespersonDivisionNo5$+\"" + Sep + "\"+" +            // 66
            "SalespersonNo5$+\"" + Sep + "\"+" +                    // 67
            "InvoiceDueDate$+\"" + Sep + "\"+" +                    // 68
            "DiscountDueDate$+\"" + Sep + "\"+" +                   // 69
            "BatchNo$+\"" + Sep + "\"+" +                           // 70
            "EBMSubmissionType$+\"" + Sep + "\"+" +                 // 71
            "EBMUserIDSubmittingThisOrder$+\"" + Sep + "\"+" +      // 72
            "EBMUserType$+\"" + Sep + "\"+" +                       // 73
            "EMailUpdateFlagForRestart$+\"" + Sep + "\"+" +         // 74
            "FaxNo$+\"" + Sep + "\"+" +                             // 75
            "BatchFax$+\"" + Sep + "\"+" +                          // 76
            "BatchEmail$+\"" + Sep + "\"+" +                        // 77
            "EmailAddress$+\"" + Sep + "\"+" +                      // 78
            "PaymentType$+\"" + Sep + "\"+" +                       // 79
            "OtherPaymentTypeRefNo$+\"" + Sep + "\"+" +             // 80
            "PaymentTypeCategory$+\"" + Sep + "\"+" +               // 81
            "OrderChangedInShipping$+\"" + Sep + "\"+" +            // 82
            "LinesChangedInShipping$+\"" + Sep + "\"+" +            // 83
            "ShipperID$+\"" + Sep + "\"+" +                         // 84
            "ShipStatus$+\"" + Sep + "\"+" +                        // 85
            "StarshipFreightUsed$+\"" + Sep + "\"+" +               // 86
            "StarshipRecordsCreated$+\"" + Sep + "\"+" +            // 87
            "JobNo$+\"" + Sep + "\"+" +                             // 88
            "RMANo$+\"" + Sep + "\"+" +                             // 89
            "CRMUserID$+\"" + Sep + "\"+" +                         // 90
            "CRMCompanyID$+\"" + Sep + "\"+" +                      // 91
            "CRMPersonID$+\"" + Sep + "\"+" +                       // 92
            "CRMOpportunityID$+\"" + Sep + "\"+" +                  // 93
            "InvalidWarrantyCode$+\"" + Sep + "\"+" +               // 94
            "STR(TaxableSubjectToDiscount)+\"" + Sep + "\"+" +      // 95
            "STR(NonTaxableSubjectToDiscount)+\"" + Sep + "\"+" +   // 96
            "STR(TaxSubjToDiscPrcntOfTotSubjTo)+\"" + Sep + "\"+" + // 97
            "STR(DiscountRate)+\"" + Sep + "\"+" +                  // 98
            "STR(TaxableAmt)+\"" + Sep + "\"+" +                    // 99
            "STR(NonTaxableAmt)+\"" + Sep + "\"+" +                 // 100
            "STR(SalesTaxAmt)+\"" + Sep + "\"+" +                   // 101
            "STR(DiscountAmt)+\"" + Sep + "\"+" +                   // 102
            "STR(RetentionAmt)+\"" + Sep + "\"+" +                  // 103
            "STR(TotalSubjectToComm)+\"" + Sep + "\"+" +            // 104
            "STR(CommissionRate)+\"" + Sep + "\"+" +                // 105
            "STR(CommissionAmt)+\"" + Sep + "\"+" +                 // 106
            "STR(SplitCommRate2)+\"" + Sep + "\"+" +                // 107
            "STR(SplitCommRate3)+\"" + Sep + "\"+" +                // 108
            "STR(SplitCommRate4)+\"" + Sep + "\"+" +                // 109
            "STR(SplitCommRate5)+\"" + Sep + "\"+" +                // 110
            "STR(OverrideCommAmt)+\"" + Sep + "\"+" +               // 111
            "STR(FreightAmt)+\"" + Sep + "\"+" +                    // 112
            "STR(CostOfGoodsSoldAmt)+\"" + Sep + "\"+" +            // 113
            "STR(CostOfGoodsSoldSubjToComm)+\"" + Sep + "\"+" +     // 114
            "STR(DepositAmt)+\"" + Sep + "\"+" +                    // 115
            "STR(Weight)+\"" + Sep + "\"+" +                        // 116
            "STR(SIShippedLinesCOGS)+\"" + Sep + "\"+" +            // 117
            "STR(NumberOfCODLabels)+\"" + Sep + "\"+" +             // 118
            "STR(NumberOfBackOrderLines)+\"" + Sep + "\"+" +        // 119
            "STR(NumberOfShippingLabels)+\"" + Sep + "\"+" +        // 120
            "STR(LastNoOfShippingLabels)+\"" + Sep + "\"+" +        // 121
            "STR(NumberofPackages)";                                // 122
    }
}
