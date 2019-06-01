namespace crgolden.Sage
{
    public abstract class Customer : Record
    {
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
        /// Customer Name
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Address Line 1
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address Line 2
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Address Line 3
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Zip Code
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Country Code
        /// FmtType: CHARNUM
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Telephone Number
        /// </summary>
        public string TelephoneNo { get; set; }

        /// <summary>
        /// Telephone Extension
        /// </summary>
        public string TelephoneExt { get; set; }

        /// <summary>
        /// Fax Number
        /// DepVal: REQUIRED
        /// </summary>
        public string FaxNo { get; set; }

        /// <summary>
        /// Email Address
        /// DepVal: REQUIRED
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// URL Address
        /// </summary>
        public string URLAddress { get; set; }

        /// <summary>
        /// eBusiness Manager Enabled
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? EBMEnabled { get; set; } = false;

        /// <summary>
        /// eBusiness Manager Consumer User
        /// DepVal: REQUIRED
        /// </summary>
        public string EBMConsumerUserID { get; set; }

        /// <summary>
        /// Batch Fax
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? BatchFax { get; set; } = false;

        /// <summary>
        /// Default Credit Card Payment Typ
        /// Read Only: Y
        /// Notes: e.g., VISA or MC.A match here will cause dflt
        /// Cred Crd info from AR1 to fill in S/O Credit Card fields.
        /// </summary>
        public string DefaultCreditCardPmtType { get; set; }

        /// <summary>
        /// Contact Code
        /// </summary>
        public string ContactCode { get; set; }

        /// <summary>
        /// Ship Method
        /// </summary>
        public string ShipMethod { get; set; }

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
        /// Terms Code
        /// DfltVal: 00
        /// Mask: 00
        /// FmtType:ZEROFILL
        /// </summary>
        public string TermsCode { get; set; } = "00";

        /// <summary>
        /// Salesperson Division Number
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// </summary>
        public string SalespersonDivisionNo { get; set; }

        /// <summary>
        /// Salesperson Number
        /// FmtType: CHARNUM
        /// </summary>
        public string SalespersonNo { get; set; }

        /// <summary>
        /// Salesperson Division Number 2
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// </summary>
        public string SalespersonDivisionNo2 { get; set; }

        /// <summary>
        /// Salesperson Number 2
        /// FmtType: CHARNUM
        /// DepVal:REQUIRED
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
        /// Customer Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Sort Field
        /// </summary>
        public string SortField { get; set; }

        /// <summary>
        /// Obsolete 5.00
        /// </summary>
        public char? TemporaryCustomer { get; set; }

        /// <summary>
        /// Customer Status
        /// DfltVal: A
        /// Valid: A, I, T
        /// Notes: A = Active, I = Inactive, T = Temporary
        /// </summary>
        public char CustomerStatus { get; set; } = 'A';

        /// <summary>
        /// Inactive Reason Code
        /// FmtType: CHARNUM
        /// </summary>
        public string InactiveReasonCode { get; set; }

        /// <summary>
        /// Open Item Customer
        /// DfltVal: Y
        /// Valid: Y, N
        /// </summary>
        public bool OpenItemCustomer { get; set; } = true;

        /// <summary>
        /// Residential Address
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? ResidentialAddress { get; set; } = false;

        /// <summary>
        /// Statement Cycle
        /// DfltVal: M
        /// </summary>
        public char? StatementCycle { get; set; } = 'M';

        /// <summary>
        /// Print Dunning Message On Statem
        /// DfltVal: Y
        /// Valid: Y, N
        /// </summary>
        public bool? PrintDunningMessage { get; set; } = true;

        /// <summary>
        /// Customer Type
        /// </summary>
        public string CustomerType { get; set; }

        /// <summary>
        /// Price Level
        /// </summary>
        public char? PriceLevel { get; set; }

        /// <summary>
        /// Date Of Last Activity
        /// </summary>
        public string DateLastActivity { get; set; }

        /// <summary>
        /// Date Of Last Payment
        /// </summary>
        public string DateLastPayment { get; set; }

        /// <summary>
        /// Date Of Last Statement
        /// </summary>
        public string DateLastStatement { get; set; }

        /// <summary>
        /// Date Of Last Finance Charge
        /// </summary>
        public string DateLastFinanceChrg { get; set; }

        /// <summary>
        /// Date Of Last Aging
        /// Read Only: Y
        /// </summary>
        public string DateLastAging { get; set; }

        /// <summary>
        /// Default Item Code
        /// FmtType: CHARNUM
        /// </summary>
        public string DefaultItemCode { get; set; }

        /// <summary>
        /// Default Cost Code
        /// </summary>
        public string DefaultCostCode { get; set; }

        /// <summary>
        /// Default Cost Type
        /// </summary>
        public char? DefaultCostType { get; set; }

        /// <summary>
        /// Customer On Credit Hold
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? CreditHold { get; set; } = false;

        /// <summary>
        /// Primary Ship To Code
        /// </summary>
        public string PrimaryShipToCode { get; set; }

        /// <summary>
        /// Date Established
        /// </summary>
        public string DateEstablished { get; set; }

        /// <summary>
        /// Sage Exchange vault credit card
        /// DepVal: REQUIRED
        /// </summary>
        public string CreditCardGUID { get; set; }

        /// <summary>
        /// Default Payment Type
        /// DfltVal: CHECK
        /// Notes: e.g., CASH or AMEX
        /// </summary>
        public string DefaultPaymentType { get; set; } = "CHECK";

        /// <summary>
        /// Obsolete 4.30
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? EmailStatements { get; set; } = false;

        /// <summary>
        /// Number Of Invoices To Use In Da
        /// Mask: 00
        /// Notes: (0-20)
        /// </summary>
        public int? NumberOfInvToUseInCalc { get; set; }

        /// <summary>
        /// Avg Days For Payment From Invoi
        /// Mask: 000
        /// </summary>
        public int? AvgDaysPaymentInvoice { get; set; }

        /// <summary>
        /// Avg Days Overdue (Pay Date - Du
        /// Mask: 000
        /// </summary>
        public int? AvgDaysOverDue { get; set; }

        /// <summary>
        /// Customer Discount Rate
        /// Mask: ##,###,###.000-
        /// </summary>
        public decimal? CustomerDiscountRate { get; set; }

        /// <summary>
        /// Service Charge Rate
        /// Mask: ##,###,###.000-
        /// </summary>
        public decimal? ServiceChargeRate { get; set; }

        /// <summary>
        /// Credit Limit
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? CreditLimit { get; set; }

        /// <summary>
        /// Last Payment Amount
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? LastPaymentAmt { get; set; }

        /// <summary>
        /// Highest Statement Balance
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? HighestStmntBalance { get; set; }

        /// <summary>
        /// Unpaid Service Charge
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? UnpaidServiceChrg { get; set; }

        /// <summary>
        /// Balance Forward
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? BalanceForward { get; set; }

        /// <summary>
        /// Current Balance
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? CurrentBalance { get; set; }

        /// <summary>
        /// Aging Category 1
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? AgingCategory1 { get; set; }

        /// <summary>
        /// Aging Category 2
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? AgingCategory2 { get; set; }

        /// <summary>
        /// Aging Category 3
        /// Mask :#,###,###,###.00-
        /// </summary>
        public decimal? AgingCategory3 { get; set; }

        /// <summary>
        /// Aging Category 4
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? AgingCategory4 { get; set; }

        /// <summary>
        /// Open Order Amount
        /// Mask: #,###,###,###.00-
        /// </summary>
        public decimal? OpenOrderAmt { get; set; }

        /// <summary>
        /// Retention Current
        /// Mask: #,###,###,###.00
        /// </summary>
        public decimal? RetentionCurrent { get; set; }

        /// <summary>
        /// Retention Aging 1
        /// Mask: #,###,###,###.00
        /// </summary>
        public decimal? RetentionAging1 { get; set; }

        /// <summary>
        /// Retention Aging 2
        /// Mask: #,###,###,###.00
        /// </summary>
        public decimal? RetentionAging2 { get; set; }

        /// <summary>
        /// Retention Aging 3
        /// Mask: #,###,###,###.00
        /// </summary>
        public decimal? RetentionAging3 { get; set; }

        /// <summary>
        /// Retention Aging 4
        /// Mask: #,###,###,###.00
        /// </summary>
        public decimal? RetentionAging4 { get; set; }

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
        /// Use Sage Cloud For Invoice Prin
        /// DfltVal: N
        /// </summary>
        public bool? UseSageCloudForInvPrinting { get; set; } = false;

        public new const string DefaultDesc = Record.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "ARDivisionNo$+\"" + Sep + "\"+" +                  // 06
            "CustomerNo$+\"" + Sep + "\"+" +                    // 07
            "CustomerName$+\"" + Sep + "\"+" +                  // 08
            "AddressLine1$+\"" + Sep + "\"+" +                  // 09
            "AddressLine2$+\"" + Sep + "\"+" +                  // 10
            "AddressLine3$+\"" + Sep + "\"+" +                  // 11
            "City$+\"" + Sep + "\"+" +                          // 12
            "State$+\"" + Sep + "\"+" +                         // 13
            "ZipCode$+\"" + Sep + "\"+" +                       // 14
            "CountryCode$+\"" + Sep + "\"+" +                   // 15
            "TelephoneNo$+\"" + Sep + "\"+" +                   // 16
            "TelephoneExt$+\"" + Sep + "\"+" +                  // 17
            "FaxNo$+\"" + Sep + "\"+" +                         // 18
            "EmailAddress$+\"" + Sep + "\"+" +                  // 19
            "URLAddress$+\"" + Sep + "\"+" +                    // 20
            "EBMEnabled$+\"" + Sep + "\"+" +                    // 21
            "EBMConsumerUserID$+\"" + Sep + "\"+" +             // 22
            "BatchFax$+\"" + Sep + "\"+" +                      // 23
            "DefaultCreditCardPmtType$+\"" + Sep + "\"+" +      // 24
            "ContactCode$+\"" + Sep + "\"+" +                   // 25
            "ShipMethod$+\"" + Sep + "\"+" +                    // 26
            "TaxSchedule$+\"" + Sep + "\"+" +                   // 27
            "TaxExemptNo$+\"" + Sep + "\"+" +                   // 28
            "TermsCode$+\"" + Sep + "\"+" +                     // 29
            "SalespersonDivisionNo$+\"" + Sep + "\"+" +         // 30
            "SalespersonNo$+\"" + Sep + "\"+" +                 // 31
            "SalespersonDivisionNo2$+\"" + Sep + "\"+" +        // 32
            "SalespersonNo2$+\"" + Sep + "\"+" +                // 33
            "SalespersonDivisionNo3$+\"" + Sep + "\"+" +        // 34
            "SalespersonNo3$+\"" + Sep + "\"+" +                // 35
            "SalespersonDivisionNo4$+\"" + Sep + "\"+" +        // 36
            "SalespersonNo4$+\"" + Sep + "\"+" +                // 37
            "SalespersonDivisionNo5$+\"" + Sep + "\"+" +        // 38
            "SalespersonNo5$+\"" + Sep + "\"+" +                // 39
            "Comment$+\"" + Sep + "\"+" +                       // 40
            "SortField$+\"" + Sep + "\"+" +                     // 41
            "TemporaryCustomer$+\"" + Sep + "\"+" +             // 42
            "CustomerStatus$+\"" + Sep + "\"+" +                // 43
            "InactiveReasonCode$+\"" + Sep + "\"+" +            // 44
            "OpenItemCustomer$+\"" + Sep + "\"+" +              // 45
            "ResidentialAddress$+\"" + Sep + "\"+" +            // 46
            "StatementCycle$+\"" + Sep + "\"+" +                // 47
            "PrintDunningMessage$+\"" + Sep + "\"+" +           // 48
            "CustomerType$+\"" + Sep + "\"+" +                  // 49
            "PriceLevel$+\"" + Sep + "\"+" +                    // 50
            "DateLastActivity$+\"" + Sep + "\"+" +              // 51
            "DateLastPayment$+\"" + Sep + "\"+" +               // 52
            "DateLastStatement$+\"" + Sep + "\"+" +             // 53
            "DateLastFinanceChrg$+\"" + Sep + "\"+" +           // 54
            "DateLastAging$+\"" + Sep + "\"+" +                 // 55
            "DefaultItemCode$+\"" + Sep + "\"+" +               // 56
            "DefaultCostCode$+\"" + Sep + "\"+" +               // 57
            "DefaultCostType$+\"" + Sep + "\"+" +               // 58
            "CreditHold$+\"" + Sep + "\"+" +                    // 59
            "PrimaryShipToCode$+\"" + Sep + "\"+" +             // 60
            "DateEstablished$+\"" + Sep + "\"+" +               // 61
            "CreditCardGUID$+\"" + Sep + "\"+" +                // 62
            "DefaultPaymentType$+\"" + Sep + "\"+" +            // 63
            "EmailStatements$+\"" + Sep + "\"+" +               // 64
            "STR(NumberOfInvToUseInCalc)+\"" + Sep + "\"+" +    // 65
            "STR(AvgDaysPaymentInvoice)+\"" + Sep + "\"+" +     // 66
            "STR(AvgDaysOverDue)+\"" + Sep + "\"+" +            // 67
            "STR(CustomerDiscountRate)+\"" + Sep + "\"+" +      // 68
            "STR(ServiceChargeRate)+\"" + Sep + "\"+" +         // 69
            "STR(CreditLimit)+\"" + Sep + "\"+" +               // 70
            "STR(LastPaymentAmt)+\"" + Sep + "\"+" +            // 71
            "STR(HighestStmntBalance)+\"" + Sep + "\"+" +       // 72
            "STR(UnpaidServiceChrg)+\"" + Sep + "\"+" +         // 73
            "STR(BalanceForward)+\"" + Sep + "\"+" +            // 74
            "STR(CurrentBalance)+\"" + Sep + "\"+" +            // 75
            "STR(AgingCategory1)+\"" + Sep + "\"+" +            // 76
            "STR(AgingCategory2)+\"" + Sep + "\"+" +            // 77
            "STR(AgingCategory3)+\"" + Sep + "\"+" +            // 78
            "STR(AgingCategory4)+\"" + Sep + "\"+" +            // 79
            "STR(OpenOrderAmt)+\"" + Sep + "\"+" +              // 80
            "STR(RetentionCurrent)+\"" + Sep + "\"+" +          // 81
            "STR(RetentionAging1)+\"" + Sep + "\"+" +           // 82
            "STR(RetentionAging2)+\"" + Sep + "\"+" +           // 83
            "STR(RetentionAging3)+\"" + Sep + "\"+" +           // 84
            "STR(RetentionAging4)+\"" + Sep + "\"+" +           // 85
            "STR(SplitCommRate2)+\"" + Sep + "\"+" +            // 86
            "STR(SplitCommRate3)+\"" + Sep + "\"+" +            // 87
            "STR(SplitCommRate4)+\"" + Sep + "\"+" +            // 88
            "STR(SplitCommRate5)+\"" + Sep + "\"+" +            // 89
            "UseSageCloudForInvPrinting$";                      // 90
    }
}
