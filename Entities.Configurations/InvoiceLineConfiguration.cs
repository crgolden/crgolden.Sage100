namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class InvoiceLineConfiguration<T> : DetailConfiguration<T>
        where T : InvoiceLine
    {
        public override void Configure(EntityTypeBuilder<T> invoiceLine)
        {
            base.Configure(invoiceLine);
            invoiceLine.HasIndex(e => new { e.InvoiceNo, e.LineKey }).IsUnique();
            invoiceLine.Property(e => e.InvoiceNo).HasMaxLength(7);
            invoiceLine.Property(e => e.ProductLine).HasMaxLength(4);
            invoiceLine.Property(e => e.OrderWarehouse).HasMaxLength(3);
            invoiceLine.Property(e => e.OrderLineKey).HasMaxLength(6);
            invoiceLine.Property(e => e.ExtendedCost).HasColumnType("decimal(12,2)");
            invoiceLine.Property(e => e.ExtendedNegQtyAdj).HasColumnType("decimal(12,2)");
            invoiceLine.Property(e => e.CommissionAmt).HasColumnType("decimal(13,2)");
            invoiceLine.ToTable("InvoiceLines");
        }
    }
}
