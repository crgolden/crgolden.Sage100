namespace crgolden.Sage100
{
    using System.ComponentModel;

    public abstract class SalesOrderHistoryHeader<TLine> : Header<TLine>
        where TLine : SalesOrderHistoryDetail
    {
        /// <summary>
        /// Sales Order Number
        /// FmtType: CHARNUM
        /// </summary>
        [ReadOnly(true)]
        public string SalesOrderNo { get; set; }

        /// <summary>
        /// Order Date
        /// DepVal: REQUIRED
        /// </summary>
        public string OrderDate { get; set; }

        /// <summary>
        /// Order Status
        /// DfltVal: N
        /// Valid: N, O, C, H
        /// Notes: N = New, O = Open, C = Closed, H = Hold
        /// </summary>
        public string OrderStatus { get; set; } = "N";

        /// <summary>
        /// Master Repeating Order Number
        /// FmtType: CHARNUM
        /// </summary>
        public string MasterRepeatingOrderNo { get; set; }

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
        /// Email Address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Residential Address
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string ResidentialAddress { get; set; } = "N";

        /// <summary>
        /// Cancellation Reason Code
        /// FmtType: CHARNUM
        /// </summary>
        public string CancelReasonCode { get; set; }

        /// <summary>
        /// Freight Calculation Method
        /// Valid: A, P, W
        /// Notes: A = Amount, P = Product line, W = Weight
        /// </summary>
        public string FreightCalculationMethod { get; set; }

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
        /// RMA Number
        /// FmtType: CHARNUM
        /// </summary>
        public string RMANo { get; set; }

        /// <summary>
        /// Job Number
        /// FmtType: CHARNUM
        /// DepVal:REQUIRED
        /// </summary>
        public string JobNo { get; set; }

        /// <summary>
        /// Last Invoice Order Date
        /// </summary>
        public string LastInvoiceDate { get; set; }

        /// <summary>
        /// Last Invoice Order Number
        /// FmtType: MASTERNUM
        /// </summary>
        public string LastInvoiceNo { get; set; }

        /// <summary>
        /// Check Number For Deposit
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string CheckNoForDeposit { get; set; }

        /// <summary>
        /// Lot/Serial Lines Exist
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string LotSerialLinesExist { get; set; } = "N";

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
        public string SplitCommissions { get; set; } = "N";

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
        /// EBM Internet User Type
        /// Valid: 1, 2
        /// Notes: (1 = bus, 2 = consumer)
        /// </summary>
        public string EBMUserType { get; set; }

        /// <summary>
        /// EBM Internet Submission Type
        /// Read Only: Y
        /// </summary>
        [ReadOnly(true)]
        public string EBMSubmissionType { get; set; }

        /// <summary>
        /// EBM Internet User ID Submitttin
        /// Read Only: Y
        /// </summary>
        [ReadOnly(true)]
        public string EBMUserIDSubmittingThisOrder { get; set; }

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
        public string PaymentTypeCategory { get; set; } = "D";

        /// <summary>
        /// Fax Number
        /// DepVal: REQUIRED
        /// </summary>
        public string FaxNo { get; set; }

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
        /// Promoted Date
        /// DepVal: REQUIRED
        /// </summary>
        public string PromotedDate { get; set; }

        /// <summary>
        /// Taxable Subject To Discount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        [ReadOnly(true)]
        public decimal? TaxableSubjectToDiscount { get; set; }

        /// <summary>
        /// Non-Taxable Subject To Discount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        [ReadOnly(true)]
        public decimal? NonTaxableSubjectToDiscount { get; set; }

        /// <summary>
        /// Tax-Subj-To-Disc % Of Total-Sub
        /// Read Only: Y
        /// Mask: ##0.00
        /// </summary>
        [ReadOnly(true)]
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
        [ReadOnly(true)]
        public decimal? TaxableAmt { get; set; }

        /// <summary>
        /// Non-Taxable Amount
        /// Read Only: Y
        /// Mask: ###,###,###.00
        /// </summary>
        [ReadOnly(true)]
        public decimal? NonTaxableAmt { get; set; }

        /// <summary>
        /// Sales Tax Amount
        /// Read Only: Y
        /// Mask: ##,###,###.00-
        /// </summary>
        [ReadOnly(true)]
        public decimal? SalesTaxAmt { get; set; }

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
        /// Invoiced Amount
        /// Mask: ###,###,###.00
        /// </summary>
        public decimal? InvoicedAmt { get; set; }

        public new const string DefaultDesc = Record.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "SalesOrderNo$+\"" + Sep + "\"+" +                      // 06
            "OrderDate$+\"" + Sep + "\"+" +                         // 07
            "OrderStatus$+\"" + Sep + "\"+" +                       // 08
            "MasterRepeatingOrderNo$+\"" + Sep + "\"+" +            // 09
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
            "EmailAddress$+\"" + Sep + "\"+" +                      // 36
            "ResidentialAddress$+\"" + Sep + "\"+" +                // 37
            "CancelReasonCode$+\"" + Sep + "\"+" +                  // 38
            "FreightCalculationMethod$+\"" + Sep + "\"+" +          // 39
            "FOB$+\"" + Sep + "\"+" +                               // 40
            "WarehouseCode$+\"" + Sep + "\"+" +                     // 41
            "ConfirmTo$+\"" + Sep + "\"+" +                         // 42
            "Comment$+\"" + Sep + "\"+" +                           // 43
            "TaxSchedule$+\"" + Sep + "\"+" +                       // 44
            "TermsCode$+\"" + Sep + "\"+" +                         // 45
            "TaxExemptNo$+\"" + Sep + "\"+" +                       // 46
            "RMANo$+\"" + Sep + "\"+" +                             // 47
            "JobNo$+\"" + Sep + "\"+" +                             // 48
            "LastInvoiceDate$+\"" + Sep + "\"+" +                   // 49
            "LastInvoiceNo$+\"" + Sep + "\"+" +                     // 50
            "CheckNoForDeposit$+\"" + Sep + "\"+" +                 // 51
            "LotSerialLinesExist$+\"" + Sep + "\"+" +               // 52
            "SalespersonDivisionNo$+\"" + Sep + "\"+" +             // 53
            "SalespersonNo$+\"" + Sep + "\"+" +                     // 54
            "SplitCommissions$+\"" + Sep + "\"+" +                  // 55
            "SalespersonDivisionNo2$+\"" + Sep + "\"+" +            // 56
            "SalespersonNo2$+\"" + Sep + "\"+" +                    // 57
            "SalespersonDivisionNo3$+\"" + Sep + "\"+" +            // 58
            "SalespersonNo3$+\"" + Sep + "\"+" +                    // 59
            "SalespersonDivisionNo4$+\"" + Sep + "\"+" +            // 60
            "SalespersonNo4$+\"" + Sep + "\"+" +                    // 61
            "SalespersonDivisionNo5$+\"" + Sep + "\"+" +            // 62
            "SalespersonNo5$+\"" + Sep + "\"+" +                    // 63
            "EBMUserType$+\"" + Sep + "\"+" +                       // 64
            "EBMSubmissionType$+\"" + Sep + "\"+" +                 // 65
            "EBMUserIDSubmittingThisOrder$+\"" + Sep + "\"+" +      // 66
            "PaymentType$+\"" + Sep + "\"+" +                       // 67
            "OtherPaymentTypeRefNo$+\"" + Sep + "\"+" +             // 68
            "PaymentTypeCategory$+\"" + Sep + "\"+" +               // 69
            "FaxNo$+\"" + Sep + "\"+" +                             // 70
            "CRMUserID$+\"" + Sep + "\"+" +                         // 71
            "CRMCompanyID$+\"" + Sep + "\"+" +                      // 72
            "CRMPersonID$+\"" + Sep + "\"+" +                       // 73
            "CRMOpportunityID$+\"" + Sep + "\"+" +                  // 74
            "PromotedDate$+\"" + Sep + "\"+" +                      // 75
            "STR(TaxableSubjectToDiscount)+\"" + Sep + "\"+" +      // 76
            "STR(NonTaxableSubjectToDiscount)+\"" + Sep + "\"+" +   // 77
            "STR(TaxSubjToDiscPrcntOfTotSubjTo)+\"" + Sep + "\"+" + // 78
            "STR(DiscountRate)+\"" + Sep + "\"+" +                  // 79
            "STR(DiscountAmt)+\"" + Sep + "\"+" +                   // 80
            "STR(TaxableAmt)+\"" + Sep + "\"+" +                    // 81
            "STR(NonTaxableAmt)+\"" + Sep + "\"+" +                 // 82
            "STR(SalesTaxAmt)+\"" + Sep + "\"+" +                   // 83
            "STR(CommissionRate)+\"" + Sep + "\"+" +                // 84
            "STR(SplitCommRate2)+\"" + Sep + "\"+" +                // 85
            "STR(SplitCommRate3)+\"" + Sep + "\"+" +                // 86
            "STR(SplitCommRate4)+\"" + Sep + "\"+" +                // 87
            "STR(SplitCommRate5)+\"" + Sep + "\"+" +                // 88
            "STR(Weight)+\"" + Sep + "\"+" +                        // 89
            "STR(FreightAmt)+\"" + Sep + "\"+" +                    // 90
            "STR(DepositAmt)+\"" + Sep + "\"+" +                    // 91
            "STR(InvoicedAmt)";                                     // 92
    }
}
