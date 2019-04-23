namespace Clarity.Sage
{
    using System.Collections.Generic;

    public abstract class Header<TLine> : Record
        where TLine : Line
    {
        /// <summary>
        /// Sales Order Number
        /// FmtType: CHARNUM
        /// </summary>
        public string SalesOrderNo { get; set; }

        /// <summary>
        /// Order Date
        /// DepVal: REQUIRED
        /// </summary>
        public string OrderDate { get; set; }

        /// <summary>
        /// Order Type
        /// Valid: S, B, M, R, Q, P
        /// Notes: S = Standard, B = Backorder, Q = Quote,
        /// M = Master order, R = Repeating order, P = Prospect Quote
        /// </summary>
        public char? OrderType { get; set; }

        /// <summary>
        /// Order Status
        /// DfltVal: N
        /// Valid: N, O, C, H
        /// Notes: N = New, O = Open, C = Closed, H = Hold
        /// </summary>
        public char? OrderStatus { get; set; }

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
        /// Terms Code
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// DepVal: REQUIRED
        /// </summary>
        public string TermsCode { get; set; }

        /// <summary>
        /// Tax Schedule
        /// FmtType: CHARNUM
        /// DepVal:REQUIRED
        /// </summary>
        public string TaxSchedule { get; set; }

        /// <summary>
        /// Tax Exempt Number
        /// Notes: (Only If Sales Tax Reporting = Yes)
        /// </summary>
        public string TaxExemptNo { get; set; }

        /// <summary>
        /// Invalid Tax Calculation
        /// DfltVal :N
        /// Valid: Y, N
        /// </summary>
        public bool? InvalidTaxCalc { get; set; }

        /// <summary>
        /// Check Number For Deposit
        /// FmtType: CHARNUM DepVal:REQUIRED
        /// </summary>
        public string CheckNoForDeposit { get; set; }

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
        public bool? BatchFax { get; set; }

        /// <summary>
        /// Batch Email
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? BatchEmail { get; set; }

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
        public char? PaymentTypeCategory { get; set; }

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
        /// Discount Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? DiscountAmt { get; set; }

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
        /// Weight
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Freight Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? FreightAmt { get; set; }

        /// <summary>
        /// Deposit Amount
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? DepositAmt { get; set; }

        /// <summary>
        /// Commission Rate
        /// Mask: ###0.000
        /// </summary>
        public decimal? CommissionRate { get; set; }

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
        /// EBM Internet Submission Type
        /// Read Only: Y
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
        public char? EBMUserType { get; set; }

        /// <summary>
        /// Freight Calculation Method
        /// Valid: A, P, W
        /// Notes: A = Amount, P = Product line, W = Weight
        /// </summary>
        public char? FreightCalculationMethod { get; set; }

        /// <summary>
        /// Lot/Serial Lines Exist
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? LotSerialLinesExist { get; set; }

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
        public char? SplitCommissions { get; set; }

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
        /// Residential Address
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? ResidentialAddress { get; set; }

        public virtual ICollection<TLine> Lines { get; set; } = new HashSet<TLine>();

        public new const string DefaultDesc = Record.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "SalesOrderNo$+\"" + Sep + "\"+" +                      // 06
            "OrderDate$+\"" + Sep + "\"+" +                         // 07
            "OrderType$+\"" + Sep + "\"+" +                         // 08
            "OrderStatus$+\"" + Sep + "\"+" +                       // 09
            "ARDivisionNo$+\"" + Sep + "\"+" +                      // 10
            "CustomerNo$+\"" + Sep + "\"+" +                        // 11
            "BillToDivisionNo$+\"" + Sep + "\"+" +                  // 12
            "BillToCustomerNo$+\"" + Sep + "\"+" +                  // 13
            "BillToName$+\"" + Sep + "\"+" +                        // 14
            "BillToAddress1$+\"" + Sep + "\"+" +                    // 15
            "BillToAddress2$+\"" + Sep + "\"+" +                    // 16
            "BillToAddress3$+\"" + Sep + "\"+" +                    // 17
            "BillToCity$+\"" + Sep + "\"+" +                        // 18
            "BillToState$+\"" + Sep + "\"+" +                       // 19
            "BillToZipCode$+\"" + Sep + "\"+" +                     // 20
            "BillToCountryCode$+\"" + Sep + "\"+" +                 // 21
            "ShipToCode$+\"" + Sep + "\"+" +                        // 22
            "ShipToName$+\"" + Sep + "\"+" +                        // 23
            "ShipToAddress1$+\"" + Sep + "\"+" +                    // 24
            "ShipToAddress2$+\"" + Sep + "\"+" +                    // 25
            "ShipToAddress3$+\"" + Sep + "\"+" +                    // 26
            "ShipToCity$+\"" + Sep + "\"+" +                        // 27
            "ShipToState$+\"" + Sep + "\"+" +                       // 28
            "ShipToZipCode$+\"" + Sep + "\"+" +                     // 29
            "ShipToCountryCode$+\"" + Sep + "\"+" +                 // 30
            "ShipVia$+\"" + Sep + "\"+" +                           // 31
            "ShipZone$+\"" + Sep + "\"+" +                          // 32
            "ShipZoneActual$+\"" + Sep + "\"+" +                    // 33
            "ShipWeight$+\"" + Sep + "\"+" +                        // 34
            "CustomerPONo$+\"" + Sep + "\"+" +                      // 35
            "FOB$+\"" + Sep + "\"+" +                               // 36
            "WarehouseCode$+\"" + Sep + "\"+" +                     // 37
            "ConfirmTo$+\"" + Sep + "\"+" +                         // 38
            "Comment$+\"" + Sep + "\"+" +                           // 39
            "TermsCode$+\"" + Sep + "\"+" +                         // 40
            "TaxSchedule$+\"" + Sep + "\"+" +                       // 41
            "TaxExemptNo$+\"" + Sep + "\"+" +                       // 42
            "InvalidTaxCalc$+\"" + Sep + "\"+" +                    // 43
            "CheckNoForDeposit$+\"" + Sep + "\"+" +                 // 44
            "FaxNo$+\"" + Sep + "\"+" +                             // 45
            "BatchFax$+\"" + Sep + "\"+" +                          // 46
            "BatchEmail$+\"" + Sep + "\"+" +                        // 47
            "EmailAddress$+\"" + Sep + "\"+" +                      // 48
            "PaymentType$+\"" + Sep + "\"+" +                       // 49
            "OtherPaymentTypeRefNo$+\"" + Sep + "\"+" +             // 50
            "PaymentTypeCategory$+\"" + Sep + "\"+" +               // 51
            "JobNo$+\"" + Sep + "\"+" +                             // 52
            "RMANo$+\"" + Sep + "\"+" +                             // 53
            "CRMUserID$+\"" + Sep + "\"+" +                         // 54
            "CRMCompanyID$+\"" + Sep + "\"+" +                      // 55
            "CRMPersonID$+\"" + Sep + "\"+" +                       // 56
            "CRMOpportunityID$+\"" + Sep + "\"+" +                  // 57
            "STR(TaxableSubjectToDiscount)+\"" + Sep + "\"+" +      // 58
            "STR(NonTaxableSubjectToDiscount)+\"" + Sep + "\"+" +   // 59
            "STR(TaxSubjToDiscPrcntOfTotSubjTo)+\"" + Sep + "\"+" + // 60
            "STR(DiscountRate)+\"" + Sep + "\"+" +                  // 61
            "STR(DiscountAmt)+\"" + Sep + "\"+" +                   // 62
            "STR(TaxableAmt)+\"" + Sep + "\"+" +                    // 63
            "STR(NonTaxableAmt)+\"" + Sep + "\"+" +                 // 64
            "STR(SalesTaxAmt)+\"" + Sep + "\"+" +                   // 65
            "STR(Weight)+\"" + Sep + "\"+" +                        // 66
            "STR(FreightAmt)+\"" + Sep + "\"+" +                    // 67
            "STR(DepositAmt)+\"" + Sep + "\"+" +                    // 68
            "STR(CommissionRate)+\"" + Sep + "\"+" +                // 69
            "STR(SplitCommRate2)+\"" + Sep + "\"+" +                // 70
            "STR(SplitCommRate3)+\"" + Sep + "\"+" +                // 71
            "STR(SplitCommRate4)+\"" + Sep + "\"+" +                // 72
            "STR(SplitCommRate5)+\"" + Sep + "\"+" +                // 73
            "STR(NumberOfShippingLabels)+\"" + Sep + "\"+" +        // 74
            "STR(LastNoOfShippingLabels)+\"" + Sep + "\"+" +        // 75
            "EBMSubmissionType$+\"" + Sep + "\"+" +                 // 76
            "EBMUserIDSubmittingThisOrder$+\"" + Sep + "\"+" +      // 77
            "EBMUserType$+\"" + Sep + "\"+" +                       // 78
            "FreightCalculationMethod$+\"" + Sep + "\"+" +          // 79
            "LotSerialLinesExist$+\"" + Sep + "\"+" +               // 80
            "SalespersonDivisionNo$+\"" + Sep + "\"+" +             // 81
            "SalespersonNo$+\"" + Sep + "\"+" +                     // 82
            "SplitCommissions$+\"" + Sep + "\"+" +                  // 83
            "SalespersonDivisionNo2$+\"" + Sep + "\"+" +            // 84
            "SalespersonNo2$+\"" + Sep + "\"+" +                    // 85
            "SalespersonDivisionNo3$+\"" + Sep + "\"+" +            // 86
            "SalespersonNo3$+\"" + Sep + "\"+" +                    // 87
            "SalespersonDivisionNo4$+\"" + Sep + "\"+" +            // 88
            "SalespersonNo4$+\"" + Sep + "\"+" +                    // 89
            "SalespersonDivisionNo5$+\"" + Sep + "\"+" +            // 90
            "SalespersonNo5$+\"" + Sep + "\"+" +                    // 91
            "ResidentialAddress$";                                  // 92
    }
}
