namespace crgolden.Sage
{
    using System.Collections.Generic;

    public abstract class SalesOrderHeader<TLine> : Record
        where TLine : SalesOrderDetail
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
        public char? OrderStatus { get; set; } = 'N';

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
        public bool? InvalidTaxCalc { get; set; } = false;

        /// <summary>
        /// Print Sales Orders
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PrintSalesOrders { get; set; } = false;

        /// <summary>
        /// Sales Order Printed
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? SalesOrderPrinted { get; set; } = false;

        /// <summary>
        /// Print Picking Sheets
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PrintPickingSheets { get; set; } = false;

        /// <summary>
        /// Picking Sheet Printed
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PickingSheetPrinted { get; set; } = false;

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
        /// Check Number For Deposit
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string CheckNoForDeposit { get; set; }

        /// <summary>
        /// Cycle Code
        /// FmtType: CHARNUM
        /// </summary>
        public string CycleCode { get; set; }

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
        /// EBM Internet User Type
        /// Valid: 1, 2
        /// Notes: (1 = bus, 2 = consumer)
        /// </summary>
        public EBMUserTypes? EBMUserType { get; set; }

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
        /// Cancellation Reason Code
        /// FmtType: CHARNUM
        /// </summary>
        public string CancelReasonCode { get; set; }

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
        /// Residential Address
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? ResidentialAddress { get; set; } = false;

        /// <summary>
        /// CRM User ID
        /// </summary>
        public string CRMUserID { get; set; }

        /// <summary>
        /// CRM Person ID
        /// </summary>
        public string CRMPersonID { get; set; }

        /// <summary>
        /// CRM Opportunity ID
        /// </summary>
        public string CRMOpportunityID { get; set; }

        /// <summary>
        /// CRM Company ID
        /// </summary>
        public string CRMCompanyID { get; set; }

        /// <summary>
        /// CRM Prospect ID
        /// </summary>
        public string CRMProspectID { get; set; }

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

        public virtual ICollection<TLine> Lines { get; set; } = new HashSet<TLine>();

        public new const string DefaultDesc = Record.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "SalesOrderNo$+\"" + Sep + "\"+" +                      // 06
            "OrderDate$+\"" + Sep + "\"+" +                         // 07
            "OrderType$+\"" + Sep + "\"+" +                         // 08
            "OrderStatus$+\"" + Sep + "\"+" +                       // 09
            "MasterRepeatingOrderNo$+\"" + Sep + "\"+" +            // 10
            "ShipExpireDate$+\"" + Sep + "\"+" +                    // 11
            "ARDivisionNo$+\"" + Sep + "\"+" +                      // 12
            "CustomerNo$+\"" + Sep + "\"+" +                        // 13
            "BillToDivisionNo$+\"" + Sep + "\"+" +                  // 14
            "BillToCustomerNo$+\"" + Sep + "\"+" +                  // 15
            "BillToName$+\"" + Sep + "\"+" +                        // 16
            "BillToAddress1$+\"" + Sep + "\"+" +                    // 17
            "BillToAddress2$+\"" + Sep + "\"+" +                    // 18
            "BillToAddress3$+\"" + Sep + "\"+" +                    // 19
            "BillToCity$+\"" + Sep + "\"+" +                        // 20
            "BillToState$+\"" + Sep + "\"+" +                       // 21
            "BillToZipCode$+\"" + Sep + "\"+" +                     // 22
            "BillToCountryCode$+\"" + Sep + "\"+" +                 // 23
            "ShipToCode$+\"" + Sep + "\"+" +                        // 24
            "ShipToName$+\"" + Sep + "\"+" +                        // 25
            "ShipToAddress1$+\"" + Sep + "\"+" +                    // 26
            "ShipToAddress2$+\"" + Sep + "\"+" +                    // 27
            "ShipToAddress3$+\"" + Sep + "\"+" +                    // 28
            "ShipToCity$+\"" + Sep + "\"+" +                        // 29
            "ShipToState$+\"" + Sep + "\"+" +                       // 30
            "ShipToZipCode$+\"" + Sep + "\"+" +                     // 31
            "ShipToCountryCode$+\"" + Sep + "\"+" +                 // 32
            "ShipVia$+\"" + Sep + "\"+" +                           // 33
            "ShipZone$+\"" + Sep + "\"+" +                          // 34
            "ShipZoneActual$+\"" + Sep + "\"+" +                    // 35
            "ShipWeight$+\"" + Sep + "\"+" +                        // 36
            "CustomerPONo$+\"" + Sep + "\"+" +                      // 37
            "FOB$+\"" + Sep + "\"+" +                               // 38
            "WarehouseCode$+\"" + Sep + "\"+" +                     // 39
            "ConfirmTo$+\"" + Sep + "\"+" +                         // 40
            "Comment$+\"" + Sep + "\"+" +                           // 41
            "TermsCode$+\"" + Sep + "\"+" +                         // 42
            "TaxSchedule$+\"" + Sep + "\"+" +                       // 43
            "TaxExemptNo$+\"" + Sep + "\"+" +                       // 44
            "InvalidTaxCalc$+\"" + Sep + "\"+" +                    // 45
            "PrintSalesOrders$+\"" + Sep + "\"+" +                  // 46
            "SalesOrderPrinted$+\"" + Sep + "\"+" +                 // 47
            "PrintPickingSheets$+\"" + Sep + "\"+" +                // 48
            "PickingSheetPrinted$+\"" + Sep + "\"+" +               // 49
            "LastInvoiceOrderDate$+\"" + Sep + "\"+" +              // 50
            "LastInvoiceOrderNo$+\"" + Sep + "\"+" +                // 51
            "CurrentInvoiceNo$+\"" + Sep + "\"+" +                  // 52
            "CheckNoForDeposit$+\"" + Sep + "\"+" +                 // 53
            "CycleCode$+\"" + Sep + "\"+" +                         // 54
            "FaxNo$+\"" + Sep + "\"+" +                             // 55
            "BatchFax$+\"" + Sep + "\"+" +                          // 56
            "BatchEmail$+\"" + Sep + "\"+" +                        // 57
            "EmailAddress$+\"" + Sep + "\"+" +                      // 58
            "FreightCalculationMethod$+\"" + Sep + "\"+" +          // 59
            "LotSerialLinesExist$+\"" + Sep + "\"+" +               // 60
            "SalespersonDivisionNo$+\"" + Sep + "\"+" +             // 61
            "SalespersonNo$+\"" + Sep + "\"+" +                     // 62
            "SplitCommissions$+\"" + Sep + "\"+" +                  // 63
            "SalespersonDivisionNo2$+\"" + Sep + "\"+" +            // 64
            "SalespersonNo2$+\"" + Sep + "\"+" +                    // 65
            "SalespersonDivisionNo3$+\"" + Sep + "\"+" +            // 66
            "SalespersonNo3$+\"" + Sep + "\"+" +                    // 67
            "SalespersonDivisionNo4$+\"" + Sep + "\"+" +            // 68
            "SalespersonNo4$+\"" + Sep + "\"+" +                    // 69
            "SalespersonDivisionNo5$+\"" + Sep + "\"+" +            // 70
            "SalespersonNo5$+\"" + Sep + "\"+" +                    // 71
            "EBMUserType$+\"" + Sep + "\"+" +                       // 72
            "EBMSubmissionType$+\"" + Sep + "\"+" +                 // 73
            "EBMUserIDSubmittingThisOrder$+\"" + Sep + "\"+" +      // 74
            "PaymentType$+\"" + Sep + "\"+" +                       // 75
            "OtherPaymentTypeRefNo$+\"" + Sep + "\"+" +             // 76
            "PaymentTypeCategory$+\"" + Sep + "\"+" +               // 77
            "CancelReasonCode$+\"" + Sep + "\"+" +                  // 78
            "RMANo$+\"" + Sep + "\"+" +                             // 79
            "JobNo$+\"" + Sep + "\"+" +                             // 80
            "ResidentialAddress$+\"" + Sep + "\"+" +                // 81
            "CRMUserID$+\"" + Sep + "\"+" +                         // 82
            "CRMPersonID$+\"" + Sep + "\"+" +                       // 83
            "CRMOpportunityID$+\"" + Sep + "\"+" +                  // 84
            "CRMCompanyID$+\"" + Sep + "\"+" +                      // 85
            "CRMProspectID$+\"" + Sep + "\"+" +                     // 86
            "STR(TaxableSubjectToDiscount)+\"" + Sep + "\"+" +      // 87
            "STR(NonTaxableSubjectToDiscount)+\"" + Sep + "\"+" +   // 88
            "STR(TaxSubjToDiscPrcntOfTotSubjTo)+\"" + Sep + "\"+" + // 89
            "STR(DiscountRate)+\"" + Sep + "\"+" +                  // 90
            "STR(DiscountAmt)+\"" + Sep + "\"+" +                   // 91
            "STR(TaxableAmt)+\"" + Sep + "\"+" +                    // 92
            "STR(NonTaxableAmt)+\"" + Sep + "\"+" +                 // 93
            "STR(SalesTaxAmt)+\"" + Sep + "\"+" +                   // 94
            "STR(Weight)+\"" + Sep + "\"+" +                        // 95
            "STR(FreightAmt)+\"" + Sep + "\"+" +                    // 96
            "STR(DepositAmt)+\"" + Sep + "\"+" +                    // 97
            "STR(CommissionRate)+\"" + Sep + "\"+" +                // 98
            "STR(SplitCommRate2)+\"" + Sep + "\"+" +                // 99
            "STR(SplitCommRate3)+\"" + Sep + "\"+" +                // 100
            "STR(SplitCommRate4)+\"" + Sep + "\"+" +                // 101
            "STR(SplitCommRate5)+\"" + Sep + "\"+" +                // 102
            "STR(NumberOfShippingLabels)+\"" + Sep + "\"+" +        // 103
            "STR(LastNoOfShippingLabels)";                          // 104
    }
}
