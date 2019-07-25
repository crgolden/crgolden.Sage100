namespace crgolden.Sage100
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class PurchaseOrderDetailConfiguration<T> : IEntityTypeConfiguration<T>
        where T : PurchaseOrderDetail
    {
        public virtual void Configure(EntityTypeBuilder<T> purchaseOrderDetail)
        {
            purchaseOrderDetail.HasIndex(e => new { e.PurchaseOrderNo, e.LineKey });
            purchaseOrderDetail.Property(e => e.PurchaseOrderNo).HasMaxLength(7);
            purchaseOrderDetail.Property(e => e.LineKey).HasMaxLength(6);
            purchaseOrderDetail.Property(e => e.LineSeqNo).HasMaxLength(14);
            purchaseOrderDetail.Property(e => e.ItemCode).HasMaxLength(30).IsRequired();
            purchaseOrderDetail.Property(e => e.ExtendedDescriptionKey).HasMaxLength(10);
            purchaseOrderDetail.Property(e => e.ItemType);
            purchaseOrderDetail.Property(e => e.ItemCodeDesc).HasMaxLength(30);
            purchaseOrderDetail.Property(e => e.UseTax);
            purchaseOrderDetail.Property(e => e.RequiredDate).HasMaxLength(8);
            purchaseOrderDetail.Property(e => e.VendorPriceCode).HasMaxLength(4);
            purchaseOrderDetail.Property(e => e.PurchasesAcctKey).HasMaxLength(9);
            purchaseOrderDetail.Property(e => e.Valuation);
            purchaseOrderDetail.Property(e => e.UnitOfMeasure).HasMaxLength(4);
            purchaseOrderDetail.Property(e => e.WarehouseCode).HasMaxLength(3);
            purchaseOrderDetail.Property(e => e.ProductLine).HasMaxLength(4);
            purchaseOrderDetail.Property(e => e.MasterLineKey).HasMaxLength(6);
            purchaseOrderDetail.Property(e => e.Reschedule);
            purchaseOrderDetail.Property(e => e.JobNo).HasMaxLength(7);
            purchaseOrderDetail.Property(e => e.CostCode).HasMaxLength(9);
            purchaseOrderDetail.Property(e => e.CostType);
            purchaseOrderDetail.Property(e => e.ReceiptOfGoodsUpdated);
            purchaseOrderDetail.Property(e => e.WorkOrderNo).HasMaxLength(7);
            purchaseOrderDetail.Property(e => e.StepNo).HasMaxLength(4);
            purchaseOrderDetail.Property(e => e.SubStepPrefix);
            purchaseOrderDetail.Property(e => e.SubStepSuffix).HasMaxLength(4);
            purchaseOrderDetail.Property(e => e.WorkOrderType);
            purchaseOrderDetail.Property(e => e.AllocateLandedCost);
            purchaseOrderDetail.Property(e => e.VendorAliasItemNo).HasMaxLength(30);
            purchaseOrderDetail.Property(e => e.TaxClass).HasMaxLength(2);
            purchaseOrderDetail.Property(e => e.CommentText).HasMaxLength(2048);
            purchaseOrderDetail.Property(e => e.AssetAccount);
            purchaseOrderDetail.Property(e => e.AssetTemplate).HasMaxLength(25);
            purchaseOrderDetail.Property(e => e.WeightReference).HasMaxLength(10);
            purchaseOrderDetail.Property(e => e.SalesOrderNo).HasMaxLength(7);
            purchaseOrderDetail.Property(e => e.CustomerPONo).HasMaxLength(15);
            purchaseOrderDetail.Property(e => e.Weight).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.QuantityOrdered).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.QuantityReceived).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.QuantityBackordered).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.MasterOriginalQty).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.MasterQtyBalance).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.MasterQtyOrderedToDate).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.QuantityInvoiced).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.UnitCost).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.OriginalUnitCost).HasColumnType("decimal(16,6)");
            purchaseOrderDetail.Property(e => e.ExtensionAmt).HasColumnType("decimal(12,2)");
            purchaseOrderDetail.Property(e => e.ReceivedAmt).HasColumnType("decimal(12,2)");
            purchaseOrderDetail.Property(e => e.InvoicedAmt).HasColumnType("decimal(12,2)");
            purchaseOrderDetail.Property(e => e.UnitOfMeasureConvFactor).HasColumnType("decimal(12,4)");
            purchaseOrderDetail.Property(e => e.ReceivedAllocatedAmt).HasColumnType("decimal(12,2)");
            purchaseOrderDetail.Property(e => e.InvoicedAllocatedAmt).HasColumnType("decimal(12,2)");
            purchaseOrderDetail.ToTable("PurchaseOrderDetails");
        }
    }
}
