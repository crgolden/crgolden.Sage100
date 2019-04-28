namespace Clarity.Sage
{
    using System.Collections.Generic;

    public abstract class PurchaseOrderHeader<TLine> : Record
        where TLine : PurchaseOrderDetail
    {
        /// <summary>
        /// Sales Order Number
        /// FmtType: CHARNUM
        /// </summary>
        public string PurchaseOrderNo { get; set; }

        /// <summary>
        /// Purchase Order Date
        /// DepVal: REQUIRED
        /// </summary>
        public string PurchaseOrderDate { get; set; }

        /// <summary>
        /// DfltVal: S
        /// Valid: S, D, M, R, X
        /// Notes: (S = Standard, D = Drop Ship, M = Master,
        /// R = Repeating, X = Material Requisition)
        /// </summary>
        public char OrderType { get; set; } = 'S';

        /// <summary>
        /// Master Repeating Order Number
        /// FmtType: CHARNUM
        /// </summary>
        public string MasterRepeatingOrderNo { get; set; }

        /// <summary>
        /// Required/Expire Date
        /// </summary>
        public string RequiredExpireDate { get; set; }

        /// <summary>
        /// AP Division Number
        /// Mask: 00
        /// DepVal: REQUIRED
        /// </summary>
        public string APDivisionNo { get; set; }

        /// <summary>
        /// Vendor Number
        /// FmtType: MASTERNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string VendorNo { get; set; }

        /// <summary>
        /// Purchase Name
        /// </summary>
        public string PurchaseName { get; set; }

        /// <summary>
        /// Purchase Address 1
        /// </summary>
        public string PurchaseAddress1 { get; set; }

        /// <summary>
        /// Purchase Address 2
        /// </summary>
        public string PurchaseAddress2 { get; set; }

        /// <summary>
        /// Purchase Address 3
        /// </summary>
        public string PurchaseAddress3 { get; set; }

        /// <summary>
        /// Purchase City
        /// </summary>
        public string PurchaseCity { get; set; }

        /// <summary>
        /// Purchase State
        /// </summary>
        public string PurchaseState { get; set; }

        /// <summary>
        /// Purchase Zip Code
        /// </summary>
        public string PurchaseZipCode { get; set; }

        /// <summary>
        /// Purchase Country Code
        /// </summary>
        public string PurchaseCountryCode { get; set; }

        /// <summary>
        /// Purchase Address Code
        /// DepVal: REQUIRED
        /// </summary>
        public string PurchaseAddressCode { get; set; }

        /// <summary>
        /// Ship-To Code
        /// </summary>
        public string ShipToCode { get; set; }

        /// <summary>
        /// Ship To Name
        /// </summary>
        public string ShipToName { get; set; }

        /// <summary>
        /// Ship To Address 1
        /// </summary>
        public string ShipToAddress1 { get; set; }

        /// <summary>
        /// Ship To Address 2
        /// </summary>
        public string ShipToAddress2 { get; set; }

        /// <summary>
        /// Ship To Address 3
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
        /// Order Status
        /// DfltVal: N
        /// Valid: N, O, B, C, X
        /// Notes: (N = New, O = Open, B = Backordered,
        /// C = Change, X = complete)
        /// </summary>
        public char? OrderStatus { get; set; } = 'N';

        /// <summary>
        /// Use Tax
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? UseTax { get; set; } = false;

        /// <summary>
        /// Print Purchase Orders
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? PrintPurchaseOrders { get; set; } = false;

        /// <summary>
        /// On Hold
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? OnHold { get; set; } = false;

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
        /// Completion Date
        /// </summary>
        public string CompletionDate { get; set; }

        /// <summary>
        /// Ship Via
        /// </summary>
        public string ShipVia { get; set; }

        /// <summary>
        /// F.O.B
        /// </summary>
        public string FOB { get; set; }

        /// <summary>
        /// Warehouse Code
        /// FmtType: CHARNUM
        /// </summary>
        public string WarehouseCode { get; set; }

        /// <summary>
        /// Confirm To
        /// </summary>
        public string ConfirmTo { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// AR Division Number If Drop Ship
        /// Mask: 00
        /// </summary>
        public string ARDivisionNo { get; set; }

        /// <summary>
        /// Customer Number If Drop Ship P/
        /// </summary>
        public string CustomerNo { get; set; }

        /// <summary>
        /// Terms Code
        /// Mask: 0
        /// FmtType: ZEROFILL
        /// </summary>
        public string TermsCode { get; set; }

        /// <summary>
        /// Last Invoice Date
        /// Read Only: Y
        /// </summary>
        public string LastInvoiceDate { get; set; }

        /// <summary>
        /// Last AP Invoice Number
        /// Read Only: Y
        /// </summary>
        public string LastInvoiceNo { get; set; }

        /// <summary>
        /// 1099 Form
        /// DfltVal: N
        /// Valid: N, M, I, D
        /// DepVal: REQUIRED
        /// </summary>
        public char? Form1099 { get; set; } = 'N';

        /// <summary>
        /// 1099 Box
        /// </summary>
        public string Box1099 { get; set; }

        /// <summary>
        /// Last Receipt Date
        /// Read Only: Y
        /// </summary>
        public string LastReceiptDate { get; set; }

        /// <summary>
        /// Last Issue Date
        /// Read Only: Y
        /// </summary>
        public string LastIssueDate { get; set; }

        /// <summary>
        /// Last PO Date
        /// Read Only: Y
        /// </summary>
        public string LastPurchaseOrderDate { get; set; }

        /// <summary>
        /// Last Receipt Number
        /// Read Only: Y
        /// </summary>
        public string LastReceiptNo { get; set; }

        /// <summary>
        /// Last Issue Number
        /// Read Only: Y
        /// </summary>
        public string LastIssueNo { get; set; }

        /// <summary>
        /// Last PO Number
        /// Read Only: Y
        /// </summary>
        public string LastPurchaseOrderNo { get; set; }

        /// <summary>
        /// Prepaid AP Check Number
        /// </summary>
        public string PrepaidCheckNo { get; set; }

        /// <summary>
        /// Fax Number
        /// </summary>
        public string FaxNo { get; set; }

        /// <summary>
        /// Tax Schedule
        /// DepVal: REQUIRED
        /// </summary>
        public string TaxSchedule { get; set; }

        /// <summary>
        /// Invalid Tax Calculation
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public bool? InvalidTaxCalc { get; set; } = false;

        /// <summary>
        /// Sales Order Number
        /// FmtType: CHARNUM
        /// </summary>
        public string SalesOrderNo { get; set; }

        /// <summary>
        /// Requisitor Name
        /// </summary>
        public string RequisitorName { get; set; }

        /// <summary>
        /// Requisitor Department
        /// </summary>
        public string RequisitorDepartment { get; set; }

        /// <summary>
        /// Prepaid Amount
        /// Mask: ###,###,###.00-
        /// </summary>
        public decimal? PrepaidAmt { get; set; }

        /// <summary>
        /// Taxable Amount
        /// Read Only: Y
        /// Mask: ###,###,###.00-
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
        /// Freight Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? FreightAmt { get; set; }

        /// <summary>
        /// Prepaid Freight Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? PrepaidFreightAmt { get; set; }

        /// <summary>
        /// Invoiced Amount
        /// Mask: ###,###,###.00-
        /// </summary>
        public decimal? InvoicedAmt { get; set; }

        /// <summary>
        /// Received Amount
        /// Mask: ###,###,###.00-
        /// </summary>
        public decimal? ReceivedAmt { get; set; }

        /// <summary>
        /// Freight and Sales Tax Invoiced
        /// Mask: ###,###,###.00-
        /// </summary>
        public decimal? FreightSalesTaxInvAmt { get; set; }

        /// <summary>
        /// Back Order Lost Amount
        /// Read Only: Y
        /// Mask: ###,###,###.00-
        /// </summary>
        public decimal? BackOrderLostAmt { get; set; }

        public virtual ICollection<TLine> Lines { get; set; } = new HashSet<TLine>();

        public new const string DefaultDesc = Record.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "PurchaseOrderNo$+\"" + Sep + "\"+" +           // 06
            "PurchaseOrderDate$+\"" + Sep + "\"+" +         // 07
            "OrderType$+\"" + Sep + "\"+" +                 // 08
            "MasterRepeatingOrderNo$+\"" + Sep + "\"+" +    // 09
            "RequiredExpireDate$+\"" + Sep + "\"+" +        // 10
            "APDivisionNo$+\"" + Sep + "\"+" +              // 11
            "VendorNo$+\"" + Sep + "\"+" +                  // 12
            "PurchaseName$+\"" + Sep + "\"+" +              // 13
            "PurchaseAddress1$+\"" + Sep + "\"+" +          // 14
            "PurchaseAddress2$+\"" + Sep + "\"+" +          // 15
            "PurchaseAddress3$+\"" + Sep + "\"+" +          // 16
            "PurchaseCity$+\"" + Sep + "\"+" +              // 17
            "PurchaseState$+\"" + Sep + "\"+" +             // 18
            "PurchaseZipCode$+\"" + Sep + "\"+" +           // 19
            "PurchaseCountryCode$+\"" + Sep + "\"+" +       // 20
            "PurchaseAddressCode$+\"" + Sep + "\"+" +       // 21
            "ShipToCode$+\"" + Sep + "\"+" +                // 22
            "ShipToName$+\"" + Sep + "\"+" +                // 23
            "ShipToAddress1$+\"" + Sep + "\"+" +            // 24
            "ShipToAddress2$+\"" + Sep + "\"+" +            // 25
            "ShipToAddress3$+\"" + Sep + "\"+" +            // 26
            "ShipToCity$+\"" + Sep + "\"+" +                // 27
            "ShipToState$+\"" + Sep + "\"+" +               // 28
            "ShipToZipCode$+\"" + Sep + "\"+" +             // 29
            "ShipToCountryCode$+\"" + Sep + "\"+" +         // 30
            "OrderStatus$+\"" + Sep + "\"+" +               // 31
            "UseTax$+\"" + Sep + "\"+" +                    // 32
            "PrintPurchaseOrders$+\"" + Sep + "\"+" +       // 33
            "OnHold$+\"" + Sep + "\"+" +                    // 34
            "BatchFax$+\"" + Sep + "\"+" +                  // 35
            "BatchEmail$+\"" + Sep + "\"+" +                // 36
            "EmailAddress$+\"" + Sep + "\"+" +              // 37
            "CompletionDate$+\"" + Sep + "\"+" +            // 38
            "ShipVia$+\"" + Sep + "\"+" +                   // 39
            "FOB$+\"" + Sep + "\"+" +                       // 40
            "WarehouseCode$+\"" + Sep + "\"+" +             // 41
            "ConfirmTo$+\"" + Sep + "\"+" +                 // 42
            "Comment$+\"" + Sep + "\"+" +                   // 43
            "ARDivisionNo$+\"" + Sep + "\"+" +              // 44
            "CustomerNo$+\"" + Sep + "\"+" +                // 45
            "TermsCode$+\"" + Sep + "\"+" +                 // 46
            "LastInvoiceDate$+\"" + Sep + "\"+" +           // 47
            "LastInvoiceNo$+\"" + Sep + "\"+" +             // 48
            "Form1099$+\"" + Sep + "\"+" +                  // 49
            "Box1099$+\"" + Sep + "\"+" +                   // 50
            "LastReceiptDate$+\"" + Sep + "\"+" +           // 51
            "LastIssueDate$+\"" + Sep + "\"+" +             // 52
            "LastPurchaseOrderDate$+\"" + Sep + "\"+" +     // 53
            "LastReceiptNo$+\"" + Sep + "\"+" +             // 54
            "LastIssueNo$+\"" + Sep + "\"+" +               // 55
            "LastPurchaseOrderNo$+\"" + Sep + "\"+" +       // 56
            "PrepaidCheckNo$+\"" + Sep + "\"+" +            // 57
            "FaxNo$+\"" + Sep + "\"+" +                     // 58
            "TaxSchedule$+\"" + Sep + "\"+" +               // 59
            "InvalidTaxCalc$+\"" + Sep + "\"+" +            // 60
            "SalesOrderNo$+\"" + Sep + "\"+" +              // 61
            "RequisitorName$+\"" + Sep + "\"+" +            // 62
            "RequisitorDepartment$+\"" + Sep + "\"+" +      // 63
            "STR(PrepaidAmt)+\"" + Sep + "\"+" +            // 64
            "STR(TaxableAmt)+\"" + Sep + "\"+" +            // 65
            "STR(NonTaxableAmt)+\"" + Sep + "\"+" +         // 66
            "STR(SalesTaxAmt)+\"" + Sep + "\"+" +           // 67
            "STR(FreightAmt)+\"" + Sep + "\"+" +            // 68
            "STR(PrepaidFreightAmt)+\"" + Sep + "\"+" +     // 69
            "STR(InvoicedAmt)+\"" + Sep + "\"+" +           // 70
            "STR(ReceivedAmt)+\"" + Sep + "\"+" +           // 71
            "STR(FreightSalesTaxInvAmt)+\"" + Sep + "\"+" + // 72
            "STR(BackOrderLostAmt)";                        // 73
    }
}
