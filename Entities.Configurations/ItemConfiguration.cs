namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class ItemConfiguration<T> : RecordConfiguration<T> where T : Item
    {
        public override void Configure(EntityTypeBuilder<T> item)
        {
            base.Configure(item);
            item.HasIndex(e => e.ItemCode).IsUnique();
            item.Property(e => e.ItemCode).HasMaxLength(30);
            item.Property(e => e.ItemType).IsRequired();
            item.Property(e => e.ItemCodeDesc).HasMaxLength(30);
            item.Property(e => e.ExtendedDescriptionKey).HasMaxLength(10);
            item.Property(e => e.UseInAR).IsRequired();
            item.Property(e => e.UseInSO).IsRequired();
            item.Property(e => e.UseInPO).IsRequired();
            item.Property(e => e.UseInBM).IsRequired();
            item.Property(e => e.CalculateCommission).IsRequired();
            item.Property(e => e.DropShip).IsRequired();
            item.Property(e => e.EBMEnabled).IsRequired();
            item.Property(e => e.AllowBackOrders).IsRequired();
            item.Property(e => e.AllowReturns).IsRequired();
            item.Property(e => e.PriceCode).HasMaxLength(4);
            item.Property(e => e.AllowTradeDiscount).IsRequired();
            item.Property(e => e.PrintReceiptLabels).IsRequired();
            item.Property(e => e.AllocateLandedCost).IsRequired();
            item.Property(e => e.InactiveItem).IsRequired();
            item.Property(e => e.ConfirmCostIncrInRcptOfGoods).IsRequired();
            item.Property(e => e.WarrantyCode).HasMaxLength(10);
            item.Property(e => e.SalesUnitOfMeasure).HasMaxLength(4);
            item.Property(e => e.PurchaseUnitOfMeasure).HasMaxLength(4);
            item.Property(e => e.StandardUnitOfMeasure).HasMaxLength(4);
            item.Property(e => e.PostToGLByDivision).IsRequired();
            item.Property(e => e.SalesAcctKey).HasMaxLength(9);
            item.Property(e => e.CostOfGoodsSoldAcctKey).HasMaxLength(9);
            item.Property(e => e.InventoryAcctKey).HasMaxLength(9);
            item.Property(e => e.PurchaseAcctKey).HasMaxLength(9);
            item.Property(e => e.ManufacturingCostAcctKey).HasMaxLength(9);
            item.Property(e => e.TaxClass).HasMaxLength(2);
            item.Property(e => e.PurchasesTaxClass).HasMaxLength(2);
            item.Property(e => e.ProductLine).HasMaxLength(4);
            item.Property(e => e.ProductType);
            item.Property(e => e.Valuation);
            item.Property(e => e.DefaultWarehouseCode).HasMaxLength(3);
            item.Property(e => e.PrimaryAPDivisionNo).HasMaxLength(2);
            item.Property(e => e.PrimaryVendorNo).HasMaxLength(7);
            item.Property(e => e.ImageFile).HasMaxLength(30);
            item.Property(e => e.LastSoldDate).HasMaxLength(8);
            item.Property(e => e.LastReceiptDate).HasMaxLength(8);
            item.Property(e => e.Category1).HasMaxLength(10);
            item.Property(e => e.Category2).HasMaxLength(10);
            item.Property(e => e.Category3).HasMaxLength(10);
            item.Property(e => e.Category4).HasMaxLength(10);
            item.Property(e => e.SalesPromotionCode).HasMaxLength(10);
            item.Property(e => e.SaleStartingDate).HasMaxLength(8);
            item.Property(e => e.SaleEndingDate).HasMaxLength(8);
            item.Property(e => e.SaleMethod).IsRequired();
            item.Property(e => e.ExplodeKitItems).IsRequired();
            item.Property(e => e.ShipWeight).HasMaxLength(10);
            item.Property(e => e.CommentText).HasMaxLength(2048);
            item.Property(e => e.RestockingMethod).IsRequired();
            item.Property(e => e.NextLotSerialNo).HasMaxLength(15);
            item.Property(e => e.InventoryCycle);
            item.Property(e => e.RoutingNo).HasMaxLength(20);
            item.Property(e => e.ProcurementType).IsRequired();
            item.Property(e => e.PlannerCode).HasMaxLength(3);
            item.Property(e => e.BuyerCode).HasMaxLength(3);
            item.Property(e => e.LowLevelCode).HasMaxLength(2);
            item.Property(e => e.PlannedByMRP).IsRequired();
            item.Property(e => e.VendorItemCode).HasMaxLength(30);
            item.Property(e => e.SetupCharge).IsRequired();
            item.Property(e => e.AttachmentFileName).HasMaxLength(30);
            item.Property(e => e.ItemImageWidthInPixels);
            item.Property(e => e.ItemImageHeightInPixels);
            item.Property(e => e.StandardUnitCost).HasColumnType("decimal(16,6)");
            item.Property(e => e.StandardUnitPrice).HasColumnType("decimal(16,6)");
            item.Property(e => e.LastTotalUnitCost).HasColumnType("decimal(16,6)");
            item.Property(e => e.AverageUnitCost).HasColumnType("decimal(16,6)");
            item.Property(e => e.SalesPromotionPrice).HasColumnType("decimal(16,6)");
            item.Property(e => e.SuggestedRetailPrice).HasColumnType("decimal(16,6)");
            item.Property(e => e.SalesPromotionDiscountPercent).HasColumnType("decimal(12,3)");
            item.Property(e => e.TotalQuantityOnHand).HasColumnType("decimal(16,6)");
            item.Property(e => e.AverageBackOrderFillDays);
            item.Property(e => e.LastAllocatedUnitCost).HasColumnType("decimal(16,6)");
            item.Property(e => e.CommissionRate).HasColumnType("decimal(9,3)");
            item.Property(e => e.BaseCommAmt).HasColumnType("decimal(12,2)");
            item.Property(e => e.PurchaseUMConvFctr).HasColumnType("decimal(12,4)");
            item.Property(e => e.SalesUMConvFctr).HasColumnType("decimal(12,4)");
            item.Property(e => e.Volume).HasColumnType("decimal(11,4)");
            item.Property(e => e.RestockingCharge).HasColumnType("decimal(11,3)");
            item.Property(e => e.TotalInventoryValue).HasColumnType("decimal(15,2)");
            item.ToTable("Items");
        }
    }
}
