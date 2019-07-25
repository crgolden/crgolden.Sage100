namespace crgolden.Sage100
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class InvoiceDetailConfiguration<T> : IEntityTypeConfiguration<T>
        where T : InvoiceDetail
    {
        public virtual void Configure(EntityTypeBuilder<T> invoiceDetail)
        {
            invoiceDetail.HasIndex(e => new { e.InvoiceNo, e.LineKey });
            invoiceDetail.Property(e => e.InvoiceNo).HasMaxLength(7);
            invoiceDetail.Property(e => e.LineKey).HasMaxLength(6);
            invoiceDetail.Property(e => e.LineSeqNo).HasMaxLength(14);
            invoiceDetail.Property(e => e.ItemCode).HasMaxLength(30).IsRequired();
            invoiceDetail.Property(e => e.ItemType).IsRequired();
            invoiceDetail.Property(e => e.ItemCodeDesc).HasMaxLength(30);
            invoiceDetail.Property(e => e.ExtendedDescriptionKey).HasMaxLength(10);
            invoiceDetail.Property(e => e.Discount);
            invoiceDetail.Property(e => e.Commissionable);
            invoiceDetail.Property(e => e.SubjectToExemption);
            invoiceDetail.Property(e => e.WarehouseCode);
            invoiceDetail.Property(e => e.ProductLine).HasMaxLength(4);
            invoiceDetail.Property(e => e.Valuation);
            invoiceDetail.Property(e => e.PriceLevel);
            invoiceDetail.Property(e => e.UnitOfMeasure).HasMaxLength(4);
            invoiceDetail.Property(e => e.DropShip);
            invoiceDetail.Property(e => e.LotSerialFullyDistributed);
            invoiceDetail.Property(e => e.SalesKitLineKey).HasMaxLength(6);
            invoiceDetail.Property(e => e.CostOfGoodsSoldAcctKey).HasMaxLength(9);
            invoiceDetail.Property(e => e.SalesAcctKey).HasMaxLength(9);
            invoiceDetail.Property(e => e.PriceOverridden);
            invoiceDetail.Property(e => e.OrderWarehouse).HasMaxLength(3);
            invoiceDetail.Property(e => e.ExplodedKitItem);
            invoiceDetail.Property(e => e.OrderLineKey).HasMaxLength(6);
            invoiceDetail.Property(e => e.Revision).HasMaxLength(3);
            invoiceDetail.Property(e => e.BillOption1).HasMaxLength(2);
            invoiceDetail.Property(e => e.BillOption2).HasMaxLength(2);
            invoiceDetail.Property(e => e.BillOption3).HasMaxLength(2);
            invoiceDetail.Property(e => e.BillOption4).HasMaxLength(2);
            invoiceDetail.Property(e => e.BillOption5).HasMaxLength(2);
            invoiceDetail.Property(e => e.BillOption6).HasMaxLength(2);
            invoiceDetail.Property(e => e.BillOption7).HasMaxLength(2);
            invoiceDetail.Property(e => e.BillOption8).HasMaxLength(2);
            invoiceDetail.Property(e => e.BillOption9).HasMaxLength(2);
            invoiceDetail.Property(e => e.BackorderKitCompLine);
            invoiceDetail.Property(e => e.StandardKitBill);
            invoiceDetail.Property(e => e.SkipPrintCompLine);
            invoiceDetail.Property(e => e.AliasItemNo).HasMaxLength(30);
            invoiceDetail.Property(e => e.TaxClass).HasMaxLength(2);
            invoiceDetail.Property(e => e.SOHistoryDetlSeqNo).HasMaxLength(14);
            invoiceDetail.Property(e => e.CustomerAction);
            invoiceDetail.Property(e => e.WarrantyCode).HasMaxLength(10);
            invoiceDetail.Property(e => e.ExpirationDate).HasMaxLength(8);
            invoiceDetail.Property(e => e.ExpirationOverridden);
            invoiceDetail.Property(e => e.CostOverridden);
            invoiceDetail.Property(e => e.ItemAction);
            invoiceDetail.Property(e => e.CostCode).HasMaxLength(9);
            invoiceDetail.Property(e => e.CostType);
            invoiceDetail.Property(e => e.CommentText).HasMaxLength(2048);
            invoiceDetail.Property(e => e.PromiseDate).HasMaxLength(8);
            invoiceDetail.Property(e => e.APDivisionNo).HasMaxLength(2);
            invoiceDetail.Property(e => e.VendorNo).HasMaxLength(7);
            invoiceDetail.Property(e => e.PurchaseOrderNo).HasMaxLength(7);
            invoiceDetail.Property(e => e.PurchaseOrderRequiredDate).HasMaxLength(8);
            invoiceDetail.Property(e => e.QuantityOrdered).HasColumnType("decimal(16,6)");
            invoiceDetail.Property(e => e.QuantityShipped).HasColumnType("decimal(16,6)");
            invoiceDetail.Property(e => e.QuantityBackordered).HasColumnType("decimal(16,6)");
            invoiceDetail.Property(e => e.UnitPrice).HasColumnType("decimal(16,6)");
            invoiceDetail.Property(e => e.ExtensionAmt).HasColumnType("decimal(12,2)");
            invoiceDetail.Property(e => e.ExtendedCost).HasColumnType("decimal(12,2)");
            invoiceDetail.Property(e => e.ExtendedNegQtyAdj).HasColumnType("decimal(12,2)");
            invoiceDetail.Property(e => e.UnitCost).HasColumnType("decimal(16,6)");
            invoiceDetail.Property(e => e.UnitOfMeasureConvFactor).HasColumnType("decimal(12,4)");
            invoiceDetail.Property(e => e.CommissionAmt).HasColumnType("decimal(13,2)");
            invoiceDetail.Property(e => e.QuantityPerBill).HasColumnType("decimal(16,6)");
            invoiceDetail.Property(e => e.LineDiscountPercent).HasColumnType("decimal(9,3)");
            invoiceDetail.Property(e => e.LineWeight).HasColumnType("decimal(12,2)");
            invoiceDetail.Property(e => e.CommodityCode).HasMaxLength(12);
            invoiceDetail.Property(e => e.AlternateTaxIdentifier).HasMaxLength(15);
            invoiceDetail.Property(e => e.TaxTypeApplied).HasMaxLength(4);
            invoiceDetail.Property(e => e.NetGrossIndicator);
            invoiceDetail.Property(e => e.DebitCreditIndicator);
            invoiceDetail.Property(e => e.TaxAmt).HasColumnType("decimal(12,2)");
            invoiceDetail.Property(e => e.TaxRate).HasColumnType("decimal(11,6)");
            invoiceDetail.ToTable("InvoiceDetails");
        }
    }
}
