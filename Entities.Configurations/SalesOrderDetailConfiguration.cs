namespace Clarity.Sage.Rdp
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class SalesOrderDetailConfiguration<T> : IEntityTypeConfiguration<T>
        where T : SalesOrderDetail
    {
        public virtual void Configure(EntityTypeBuilder<T> salesOrderDetail)
        {
            salesOrderDetail.HasIndex(e => new { e.SalesOrderNo, e.LineKey }).IsUnique();
            salesOrderDetail.Property(e => e.SalesOrderNo).HasMaxLength(7);
            salesOrderDetail.Property(e => e.LineKey).HasMaxLength(6).IsRequired();
            salesOrderDetail.Property(e => e.LineSeqNo).HasMaxLength(14).IsRequired();
            salesOrderDetail.Property(e => e.ItemCode).HasMaxLength(30).IsRequired();
            salesOrderDetail.Property(e => e.ItemType).IsRequired();
            salesOrderDetail.Property(e => e.ItemCodeDesc).HasMaxLength(30);
            salesOrderDetail.Property(e => e.ExtendedDescriptionKey).HasMaxLength(10);
            salesOrderDetail.Property(e => e.Discount);
            salesOrderDetail.Property(e => e.Commissionable);
            salesOrderDetail.Property(e => e.SubjectToExemption);
            salesOrderDetail.Property(e => e.WarehouseCode);
            salesOrderDetail.Property(e => e.Valuation);
            salesOrderDetail.Property(e => e.PriceLevel);
            salesOrderDetail.Property(e => e.MasterOrderLineKey).HasMaxLength(6);
            salesOrderDetail.Property(e => e.UnitOfMeasure).HasMaxLength(4);
            salesOrderDetail.Property(e => e.DropShip);
            salesOrderDetail.Property(e => e.LotSerialFullyDistributed);
            salesOrderDetail.Property(e => e.PrintDropShipment);
            salesOrderDetail.Property(e => e.SalesKitLineKey).HasMaxLength(6);
            salesOrderDetail.Property(e => e.CostOfGoodsSoldAcctKey).HasMaxLength(9);
            salesOrderDetail.Property(e => e.SalesAcctKey).HasMaxLength(9);
            salesOrderDetail.Property(e => e.PriceOverridden);
            salesOrderDetail.Property(e => e.ExplodedKitItem);
            salesOrderDetail.Property(e => e.StandardKitBill);
            salesOrderDetail.Property(e => e.Revision).HasMaxLength(3);
            salesOrderDetail.Property(e => e.BillOption1).HasMaxLength(2);
            salesOrderDetail.Property(e => e.BillOption2).HasMaxLength(2);
            salesOrderDetail.Property(e => e.BillOption3).HasMaxLength(2);
            salesOrderDetail.Property(e => e.BillOption4).HasMaxLength(2);
            salesOrderDetail.Property(e => e.BillOption5).HasMaxLength(2);
            salesOrderDetail.Property(e => e.BillOption6).HasMaxLength(2);
            salesOrderDetail.Property(e => e.BillOption7).HasMaxLength(2);
            salesOrderDetail.Property(e => e.BillOption8).HasMaxLength(2);
            salesOrderDetail.Property(e => e.BillOption9).HasMaxLength(2);
            salesOrderDetail.Property(e => e.BackorderKitCompLine);
            salesOrderDetail.Property(e => e.SkipPrintCompLine);
            salesOrderDetail.Property(e => e.PromiseDate).HasMaxLength(8);
            salesOrderDetail.Property(e => e.AliasItemNo).HasMaxLength(30);
            salesOrderDetail.Property(e => e.SOHistoryDetlSeqNo).HasMaxLength(14);
            salesOrderDetail.Property(e => e.TaxClass).HasMaxLength(2);
            salesOrderDetail.Property(e => e.CustomerAction);
            salesOrderDetail.Property(e => e.ItemAction);
            salesOrderDetail.Property(e => e.WarrantyCode).HasMaxLength(10);
            salesOrderDetail.Property(e => e.ExpirationDate).HasMaxLength(8);
            salesOrderDetail.Property(e => e.ExpirationOverridden);
            salesOrderDetail.Property(e => e.CostOverridden);
            salesOrderDetail.Property(e => e.CostCode).HasMaxLength(9);
            salesOrderDetail.Property(e => e.CostType);
            salesOrderDetail.Property(e => e.CommentText).HasMaxLength(2048);
            salesOrderDetail.Property(e => e.APDivisionNo).HasMaxLength(2);
            salesOrderDetail.Property(e => e.VendorNo).HasMaxLength(7);
            salesOrderDetail.Property(e => e.PurchaseOrderNo).HasMaxLength(7);
            salesOrderDetail.Property(e => e.PurchaseOrderRequiredDate).HasMaxLength(8);
            salesOrderDetail.Property(e => e.QuantityOrdered).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.QuantityShipped).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.QuantityBackordered).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.MasterOriginalQty).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.MasterQtyBalance).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.MasterQtyOrderedToDate).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.RepeatingQtyShippedToDate).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.UnitPrice).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.UnitCost).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.ExtensionAmt).HasColumnType("decimal(12,2)");
            salesOrderDetail.Property(e => e.UnitOfMeasureConvFactor).HasColumnType("decimal(12,4)");
            salesOrderDetail.Property(e => e.QuantityPerBill).HasColumnType("decimal(16,6)");
            salesOrderDetail.Property(e => e.LineDiscountPercent).HasColumnType("decimal(9,3)");
            salesOrderDetail.Property(e => e.LineWeight).HasColumnType("decimal(12,2)");
            salesOrderDetail.Property(e => e.CommodityCode).HasMaxLength(12);
            salesOrderDetail.Property(e => e.AlternateTaxIdentifier).HasMaxLength(15);
            salesOrderDetail.Property(e => e.TaxTypeApplied).HasMaxLength(4);
            salesOrderDetail.Property(e => e.NetGrossIndicator);
            salesOrderDetail.Property(e => e.DebitCreditIndicator);
            salesOrderDetail.Property(e => e.TaxAmt).HasColumnType("decimal(12,2)");
            salesOrderDetail.Property(e => e.TaxRate).HasColumnType("decimal(11,6)");
            salesOrderDetail.ToTable("SalesOrderDetails");
        }
    }
}
