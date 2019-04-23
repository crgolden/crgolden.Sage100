namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class DetailConfiguration<T> : IEntityTypeConfiguration<T>
        where T : Line
    {
        public virtual void Configure(EntityTypeBuilder<T> detail)
        {
            detail.Property(e => e.LineKey).HasMaxLength(6).IsRequired();
            detail.Property(e => e.LineSeqNo).HasMaxLength(14).IsRequired();
            detail.Property(e => e.ItemCode).HasMaxLength(30).IsRequired();
            detail.Property(e => e.ItemType).IsRequired();
            detail.Property(e => e.ItemCodeDesc).HasMaxLength(30);
            detail.Property(e => e.ExtendedDescriptionKey).HasMaxLength(10);
            detail.Property(e => e.Discount);
            detail.Property(e => e.Commissionable);
            detail.Property(e => e.SubjectToExemption);
            detail.Property(e => e.WarehouseCode);
            detail.Property(e => e.PriceLevel);
            detail.Property(e => e.Valuation);
            detail.Property(e => e.UnitOfMeasure).HasMaxLength(4);
            detail.Property(e => e.DropShip);
            detail.Property(e => e.LotSerialFullyDistributed);
            detail.Property(e => e.SalesKitLineKey).HasMaxLength(6);
            detail.Property(e => e.CostOfGoodsSoldAcctKey).HasMaxLength(9);
            detail.Property(e => e.SalesAcctKey).HasMaxLength(9);
            detail.Property(e => e.PriceOverridden);
            detail.Property(e => e.ExplodedKitItem);
            detail.Property(e => e.StandardKitBill);
            detail.Property(e => e.Revision).HasMaxLength(3);
            detail.Property(e => e.BillOption1).HasMaxLength(2);
            detail.Property(e => e.BillOption2).HasMaxLength(2);
            detail.Property(e => e.BillOption3).HasMaxLength(2);
            detail.Property(e => e.BillOption4).HasMaxLength(2);
            detail.Property(e => e.BillOption5).HasMaxLength(2);
            detail.Property(e => e.BillOption6).HasMaxLength(2);
            detail.Property(e => e.BillOption7).HasMaxLength(2);
            detail.Property(e => e.BillOption8).HasMaxLength(2);
            detail.Property(e => e.BillOption9).HasMaxLength(2);
            detail.Property(e => e.BackorderKitCompLine);
            detail.Property(e => e.SkipPrintCompLine);
            detail.Property(e => e.AliasItemNo).HasMaxLength(30);
            detail.Property(e => e.TaxClass).HasMaxLength(2);
            detail.Property(e => e.SOHistoryDetlSeqNo).HasMaxLength(14);
            detail.Property(e => e.CustomerAction);
            detail.Property(e => e.ItemAction);
            detail.Property(e => e.WarrantyCode).HasMaxLength(10);
            detail.Property(e => e.ExpirationDate).HasMaxLength(8);
            detail.Property(e => e.ExpirationOverridden);
            detail.Property(e => e.CostOverridden);
            detail.Property(e => e.CostCode).HasMaxLength(9);
            detail.Property(e => e.CostType);
            detail.Property(e => e.CommentText).HasMaxLength(2048);
            detail.Property(e => e.PromiseDate).HasMaxLength(8);
            detail.Property(e => e.QuantityOrdered).HasColumnType("decimal(16,6)");
            detail.Property(e => e.QuantityShipped).HasColumnType("decimal(16,6)");
            detail.Property(e => e.QuantityBackordered).HasColumnType("decimal(16,6)");
            detail.Property(e => e.UnitPrice).HasColumnType("decimal(16,6)");
            detail.Property(e => e.UnitCost).HasColumnType("decimal(16,6)");
            detail.Property(e => e.ExtensionAmt).HasColumnType("decimal(12,2)");
            detail.Property(e => e.UnitOfMeasureConvFactor).HasColumnType("decimal(12,4)");
            detail.Property(e => e.QuantityPerBill).HasColumnType("decimal(16,6)");
            detail.Property(e => e.LineDiscountPercent).HasColumnType("decimal(9,3)");
            detail.Property(e => e.APDivisionNo).HasMaxLength(2);
            detail.Property(e => e.VendorNo).HasMaxLength(7);
            detail.Property(e => e.PurchaseOrderNo).HasMaxLength(7);
            detail.Property(e => e.PurchaseOrderRequiredDate).HasMaxLength(8);
            detail.Property(e => e.LineWeight).HasColumnType("decimal(12,2)");
            detail.Property(e => e.CommodityCode).HasMaxLength(12);
            detail.Property(e => e.AlternateTaxIdentifier).HasMaxLength(15);
            detail.Property(e => e.TaxTypeApplied).HasMaxLength(4);
            detail.Property(e => e.NetGrossIndicator);
            detail.Property(e => e.DebitCreditIndicator);
            detail.Property(e => e.TaxAmt).HasColumnType("decimal(12,2)");
            detail.Property(e => e.TaxRate).HasColumnType("decimal(11,6)");
        }
    }
}
