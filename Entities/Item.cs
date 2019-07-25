namespace crgolden.Sage100
{
    using System.ComponentModel;

    public abstract class Item : Record
    {
        /// <summary>
        /// Item Code
        /// </summary>
        [ReadOnly(true)]
        public string ItemCode { get; set; }

        /// <summary>
        /// Item Type
        /// Valid: 1, 3, 4, 5
        /// 1 = Regular Item,
        /// 3 = Charge Item,
        /// 4 = Comment Item,
        /// 5 = Miscellaneous Item
        /// </summary>
        public string ItemType { get; set; }

        /// <summary>
        /// Item Code Description
        /// </summary>
        public string ItemCodeDesc { get; set; }

        /// <summary>
        /// Extended Description Key
        /// Read Only: Y
        /// </summary>
        [ReadOnly(true)]
        public string ExtendedDescriptionKey { get; set; }

        /// <summary>
        /// Use In AR
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Always "N" for Item Type "1"
        /// </summary>
        public string UseInAR { get; set; } = "N";

        /// <summary>
        /// Use In SO
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string UseInSO { get; set; } = "N";

        /// <summary>
        /// Use In PO
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string UseInPO { get; set; } = "N";

        /// <summary>
        /// Use In BM
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string UseInBM { get; set; } = "N";

        /// <summary>
        /// Calculate Commission
        /// DfltVal: N
        /// Valid: Y, N, S, P, C, G
        /// Notes: Type 5 valid values are Y = Yes, N = No.
        /// Type 1 valid values are N = No, S = Standard,
        /// P =% of Price, C=% of Cost, G =% of Gross Profit
        /// </summary>
        public string CalculateCommission { get; set; } = "N";

        /// <summary>
        /// Drop Ship
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string DropShip { get; set; } = "N";

        /// <summary>
        /// eBusiness Manager Enabled
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string EBMEnabled { get; set; } = "N";

        /// <summary>
        /// Allow Back Orders
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string AllowBackOrders { get; set; } = "N";

        /// <summary>
        /// Allow Returns
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string AllowReturns { get; set; } = "N";

        /// <summary>
        /// Price Code
        /// </summary>
        public string PriceCode { get; set; }

        /// <summary>
        /// Allow Trade Discount
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string AllowTradeDiscount { get; set; } = "N";

        /// <summary>
        /// Print Receipt Labels
        /// DfltVal: N
        /// Valid: Y, N, I
        /// Notes: Y = Yes, N = No, I = Item
        /// </summary>
        public string PrintReceiptLabels { get; set; } = "N";

        /// <summary>
        /// Allocate Landed Cost
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string AllocateLandedCost { get; set; } = "N";

        /// <summary>
        /// Inactive Item
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string InactiveItem { get; set; } = "N";

        /// <summary>
        /// Confirm Cost Increase in Receip
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string ConfirmCostIncrInRcptOfGoods { get; set; } = "N";

        /// <summary>
        /// Warranty Code
        /// </summary>
        public string WarrantyCode { get; set; }

        /// <summary>
        /// Sales Unit of Measure
        /// DepVal: REQUIRED
        /// </summary>
        public string SalesUnitOfMeasure { get; set; }

        /// <summary>
        /// Purchase Unit of Measure
        /// DepVal: REQUIRED
        /// </summary>
        public string PurchaseUnitOfMeasure { get; set; }

        /// <summary>
        /// Standard Unit of Measure
        /// DepVal: REQUIRED
        /// </summary>
        public string StandardUnitOfMeasure { get; set; }

        /// <summary>
        /// Post to G/L By Division
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Used by AR Sales Codes
        /// </summary>
        public string PostToGLByDivision { get; set; } = "N";

        /// <summary>
        /// Sales Account Key
        /// Notes: Used by Misc.Charges, Misc.Items and AR Sales Codes
        /// </summary>
        public string SalesAcctKey { get; set; }

        /// <summary>
        /// Cost Of Goods Sold Account Key
        /// </summary>
        public string CostOfGoodsSoldAcctKey { get; set; }

        /// <summary>
        /// Inventory Account Key
        /// Notes: Used by AR Sales
        /// </summary>
        public string InventoryAcctKey { get; set; }

        /// <summary>
        /// Purchase Account Key
        /// Notes: Used by Misc.Items.
        /// </summary>
        public string PurchaseAcctKey { get; set; }

        /// <summary>
        /// Manufacturing Cost Account Key
        /// </summary>
        public string ManufacturingCostAcctKey { get; set; }

        /// <summary>
        /// Tax Class
        /// DepVal: REQUIRED
        /// </summary>
        public string TaxClass { get; set; }

        /// <summary>
        /// Purchases Tax Class
        /// DepVal: REQUIRED
        /// </summary>
        public string PurchasesTaxClass { get; set; }

        /// <summary>
        /// Product Line
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string ProductLine { get; set; }

        /// <summary>
        /// Product Type
        /// Valid: F, R, D, K,
        /// DepVal: REQUIRED
        /// Notes: F = Finished Good, R = Raw Material,
        /// D = Discontinued, K = Kit, Space = Blank
        /// </summary>
        public string ProductType { get; set; }

        /// <summary>
        /// Valuation
        /// Valid: 1, 2, 3, 4, 5, 6,
        /// DepVal: REQUIRED
        /// Notes: 1 = Standard, 2 = Average, 3 = Fifo, 4 = Lifo,
        /// 5 = Lot, 6 = Serial, Space = Blank
        /// </summary>
        public string Valuation { get; set; }

        /// <summary>
        /// Default Warehouse Code
        /// FmtType: CHARNUM
        /// DepVal: REQUIRED
        /// </summary>
        public string DefaultWarehouseCode { get; set; }

        /// <summary>
        /// Primary AP Division Number
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// </summary>
        public string PrimaryAPDivisionNo { get; set; }

        /// <summary>
        /// Primary Vendor Number
        /// FmtType: MASTERNUM
        /// </summary>
        public string PrimaryVendorNo { get; set; }

        /// <summary>
        /// Image File
        /// </summary>
        public string ImageFile { get; set; }

        /// <summary>
        /// Last Sold Date
        /// </summary>
        public string LastSoldDate { get; set; }

        /// <summary>
        /// Last Receipt Date
        /// </summary>
        public string LastReceiptDate { get; set; }

        /// <summary>
        /// Category 1
        /// </summary>
        public string Category1 { get; set; }

        /// <summary>
        /// Category 2
        /// </summary>
        public string Category2 { get; set; }

        /// <summary>
        /// Category 3
        /// </summary>
        public string Category3 { get; set; }

        /// <summary>
        /// Category 4
        /// </summary>
        public string Category4 { get; set; }

        /// <summary>
        /// Sales Promotion Code
        /// DepVal: REQUIRED
        /// </summary>
        public string SalesPromotionCode { get; set; }

        /// <summary>
        /// Sale Starting Date
        /// </summary>
        public string SaleStartingDate { get; set; }

        /// <summary>
        /// Sale Ending Date
        /// </summary>
        public string SaleEndingDate { get; set; }

        /// <summary>
        /// Sale Method
        /// DfltVal: N
        /// Valid: D, P, N
        /// Notes: D = Sales Discount, P = Sale Price, N = None
        /// </summary>
        public string SaleMethod { get; set; } = "N";

        /// <summary>
        /// Explode Kit Items
        /// DfltVal: N
        /// Valid: A, N, P
        /// Notes: A = Always, N = Never, P = Prompt
        /// </summary>
        public string ExplodeKitItems { get; set; } = "N";

        /// <summary>
        /// Ship Weight
        /// </summary>
        public string ShipWeight { get; set; }

        /// <summary>
        /// Comment Text
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        /// Restocking Method
        /// DfltVal: N
        /// Valid: N, F, C, P
        /// Notes: N = None, F = Fixed, C = % of Cost, P = % of Price
        /// Read Only: Y
        /// </summary>
        [ReadOnly(true)]
        public string RestockingMethod { get; set; }

        /// <summary>
        /// Next Lot/Serial Number
        /// </summary>
        public string NextLotSerialNo { get; set; }

        /// <summary>
        /// Inventory Cycle
        /// </summary>
        public string InventoryCycle { get; set; }

        /// <summary>
        /// Routing Number
        /// </summary>
        public string RoutingNo { get; set; }

        /// <summary>
        /// Procurement Type
        /// DfltVal: B
        /// Valid: B, M, S
        /// Notes: B = Buy, M = Make, S = Subcontract
        /// </summary>
        public string ProcurementType { get; set; } = "B";

        /// <summary>
        /// Planner Code
        /// FmtType: CHARNUM
        /// </summary>
        public string PlannerCode { get; set; }

        /// <summary>
        /// Buyer Code
        /// FmtType: CHARNUM
        /// </summary>
        public string BuyerCode { get; set; }

        /// <summary>
        /// Low Level Code
        /// Mask: 00
        /// </summary>
        public string LowLevelCode { get; set; }

        /// <summary>
        /// Planned By Mrp
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string PlannedByMRP { get; set; } = "N";

        /// <summary>
        /// Vendor Item Code
        /// </summary>
        public string VendorItemCode { get; set; }

        /// <summary>
        /// Setup Charge
        /// DfltVal: N
        /// Valid: Y, N
        /// </summary>
        public string SetupCharge { get; set; } = "N";

        /// <summary>
        /// Attachment File Name
        /// Notes: From SO Only
        /// </summary>
        public string AttachmentFileName { get; set; }

        /// <summary>
        /// Item Image Width In Pixels
        /// </summary>
        public int? ItemImageWidthInPixels { get; set; }

        /// <summary>
        /// Item Image Height In Pixels
        /// </summary>
        public int? ItemImageHeightInPixels { get; set; }

        /// <summary>
        /// Standard Unit Cost
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? StandardUnitCost { get; set; }

        /// <summary>
        /// Standard  Unit Price
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? StandardUnitPrice { get; set; }

        /// <summary>
        /// Last Total Unit Cost
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? LastTotalUnitCost { get; set; }

        /// <summary>
        /// Average Unit Cost
        /// Read Only: Y
        /// Mask: ##,###,###.000000-
        /// </summary>
        [ReadOnly(true)]
        public decimal? AverageUnitCost { get; set; }

        /// <summary>
        /// Sales Promotion Price
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? SalesPromotionPrice { get; set; }

        /// <summary>
        /// Suggested Retail Price
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? SuggestedRetailPrice { get; set; }

        /// <summary>
        /// Sales Promotion Discount Percen
        /// Mask: #######0.000
        /// </summary>
        public decimal? SalesPromotionDiscountPercent { get; set; }

        /// <summary>
        /// Total Quantity On Hand
        /// Read Only: Y
        /// Mask: ##,###,###.000000-
        /// </summary>
        [ReadOnly(true)]
        public decimal? TotalQuantityOnHand { get; set; }

        /// <summary>
        /// Average Back Order Fill Days
        /// Mask: ####0
        /// </summary>
        public int? AverageBackOrderFillDays { get; set; }

        /// <summary>
        /// Last Allocated Unit Cost
        /// Mask: ##,###,###.000000-
        /// </summary>
        public decimal? LastAllocatedUnitCost { get; set; }

        /// <summary>
        /// Commission Rate
        /// Mask: ###0.000
        /// </summary>
        public decimal? CommissionRate { get; set; }

        /// <summary>
        /// Base Commission Amount
        /// Mask: ##,###,###.00-
        /// </summary>
        public decimal? BaseCommAmt { get; set; }

        /// <summary>
        /// Purchase Unit of Measure Conver
        /// Mask: #####0.0000
        /// DepVal: REQUIRED
        /// </summary>
        public decimal? PurchaseUMConvFctr { get; set; }

        /// <summary>
        /// Sales Unit of Measure Conversio
        /// Mask: #####0.0000
        /// DepVal: REQUIRED
        /// </summary>
        public decimal? SalesUMConvFctr { get; set; }

        /// <summary>
        /// Volume
        /// Mask: ##,##0.0000
        /// </summary>
        public decimal? Volume { get; set; }

        /// <summary>
        /// Restocking Charge
        /// Mask: ###,##0.000
        /// </summary>
        public decimal? RestockingCharge { get; set; }

        /// <summary>
        /// Total Inventory Value
        /// Read Only: Y
        /// </summary>
        [ReadOnly(true)]
        public decimal? TotalInventoryValue { get; set; }

        public new const string DefaultDesc = Record.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "ItemCode$+\"" + Sep + "\"+" +                          // 06
            "ItemType$+\"" + Sep + "\"+" +                          // 07
            "ItemCodeDesc$+\"" + Sep + "\"+" +                      // 08
            "ExtendedDescriptionKey$+\"" + Sep + "\"+" +            // 09
            "UseInAR$+\"" + Sep + "\"+" +                           // 10
            "UseInSO$+\"" + Sep + "\"+" +                           // 11
            "UseInPO$+\"" + Sep + "\"+" +                           // 12
            "UseInBM$+\"" + Sep + "\"+" +                           // 13
            "CalculateCommission$+\"" + Sep + "\"+" +               // 14
            "DropShip$+\"" + Sep + "\"+" +                          // 15
            "EBMEnabled$+\"" + Sep + "\"+" +                        // 16
            "AllowBackOrders$+\"" + Sep + "\"+" +                   // 17
            "AllowReturns$+\"" + Sep + "\"+" +                      // 18
            "PriceCode$+\"" + Sep + "\"+" +                         // 19
            "AllowTradeDiscount$+\"" + Sep + "\"+" +                // 20
            "PrintReceiptLabels$+\"" + Sep + "\"+" +                // 21
            "AllocateLandedCost$+\"" + Sep + "\"+" +                // 22
            "InactiveItem$+\"" + Sep + "\"+" +                      // 23
            "ConfirmCostIncrInRcptOfGoods$+\"" + Sep + "\"+" +      // 24
            "WarrantyCode$+\"" + Sep + "\"+" +                      // 25
            "SalesUnitOfMeasure$+\"" + Sep + "\"+" +                // 26
            "PurchaseUnitOfMeasure$+\"" + Sep + "\"+" +             // 27
            "StandardUnitOfMeasure$+\"" + Sep + "\"+" +             // 28
            "PostToGLByDivision$+\"" + Sep + "\"+" +                // 29
            "SalesAcctKey$+\"" + Sep + "\"+" +                      // 30
            "CostOfGoodsSoldAcctKey$+\"" + Sep + "\"+" +            // 31
            "InventoryAcctKey$+\"" + Sep + "\"+" +                  // 32
            "PurchaseAcctKey$+\"" + Sep + "\"+" +                   // 33
            "ManufacturingCostAcctKey$+\"" + Sep + "\"+" +          // 34
            "TaxClass$+\"" + Sep + "\"+" +                          // 35
            "PurchasesTaxClass$+\"" + Sep + "\"+" +                 // 36
            "ProductLine$+\"" + Sep + "\"+" +                       // 37
            "ProductType$+\"" + Sep + "\"+" +                       // 38
            "Valuation$+\"" + Sep + "\"+" +                         // 39
            "DefaultWarehouseCode$+\"" + Sep + "\"+" +              // 40
            "PrimaryAPDivisionNo$+\"" + Sep + "\"+" +               // 41
            "PrimaryVendorNo$+\"" + Sep + "\"+" +                   // 42
            "ImageFile$+\"" + Sep + "\"+" +                         // 43
            "LastSoldDate$+\"" + Sep + "\"+" +                      // 44
            "LastReceiptDate$+\"" + Sep + "\"+" +                   // 45
            "Category1$+\"" + Sep + "\"+" +                         // 46
            "Category2$+\"" + Sep + "\"+" +                         // 47
            "Category3$+\"" + Sep + "\"+" +                         // 48
            "Category4$+\"" + Sep + "\"+" +                         // 49
            "SalesPromotionCode$+\"" + Sep + "\"+" +                // 50
            "SaleStartingDate$+\"" + Sep + "\"+" +                  // 51
            "SaleEndingDate$+\"" + Sep + "\"+" +                    // 52
            "SaleMethod$+\"" + Sep + "\"+" +                        // 53
            "ExplodeKitItems$+\"" + Sep + "\"+" +                   // 54
            "ShipWeight$+\"" + Sep + "\"+" +                        // 55
            "CommentText$+\"" + Sep + "\"+" +                       // 56
            "RestockingMethod$+\"" + Sep + "\"+" +                  // 57
            "NextLotSerialNo$+\"" + Sep + "\"+" +                   // 58
            "InventoryCycle$+\"" + Sep + "\"+" +                    // 59
            "RoutingNo$+\"" + Sep + "\"+" +                         // 60
            "ProcurementType$+\"" + Sep + "\"+" +                   // 61
            "PlannerCode$+\"" + Sep + "\"+" +                       // 62
            "BuyerCode$+\"" + Sep + "\"+" +                         // 63
            "LowLevelCode$+\"" + Sep + "\"+" +                      // 64
            "PlannedByMRP$+\"" + Sep + "\"+" +                      // 65
            "VendorItemCode$+\"" + Sep + "\"+" +                    // 66
            "SetupCharge$+\"" + Sep + "\"+" +                       // 67
            "AttachmentFileName$+\"" + Sep + "\"+" +                // 68
            "STR(ItemImageWidthInPixels)+\"" + Sep + "\"+" +        // 69
            "STR(ItemImageHeightInPixels)+\"" + Sep + "\"+" +       // 70
            "STR(StandardUnitCost)+\"" + Sep + "\"+" +              // 71
            "STR(StandardUnitPrice)+\"" + Sep + "\"+" +             // 72
            "STR(LastTotalUnitCost)+\"" + Sep + "\"+" +             // 73
            "STR(AverageUnitCost)+\"" + Sep + "\"+" +               // 74
            "STR(SalesPromotionPrice)+\"" + Sep + "\"+" +           // 75
            "STR(SuggestedRetailPrice)+\"" + Sep + "\"+" +          // 76
            "STR(SalesPromotionDiscountPercent)+\"" + Sep + "\"+" + // 77
            "STR(TotalQuantityOnHand)+\"" + Sep + "\"+" +           // 78
            "STR(AverageBackOrderFillDays)+\"" + Sep + "\"+" +      // 79
            "STR(LastAllocatedUnitCost)+\"" + Sep + "\"+" +         // 80
            "STR(CommissionRate)+\"" + Sep + "\"+" +                // 81
            "STR(BaseCommAmt)+\"" + Sep + "\"+" +                   // 82
            "STR(PurchaseUMConvFctr)+\"" + Sep + "\"+" +            // 83
            "STR(SalesUMConvFctr)+\"" + Sep + "\"+" +               // 84
            "STR(Volume)+\"" + Sep + "\"+" +                        // 85
            "STR(RestockingCharge)+\"" + Sep + "\"+" +              // 86
            "STR(TotalInventoryValue)";                             // 87
    }
}
