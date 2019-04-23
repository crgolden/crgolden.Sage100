namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class OrderLineConfiguration<T> : DetailConfiguration<T>
        where T : OrderLine
    {
        public override void Configure(EntityTypeBuilder<T> orderLine)
        {
            base.Configure(orderLine);
            orderLine.HasIndex(e => new { e.SalesOrderNo, e.LineKey }).IsUnique();
            orderLine.Property(e => e.SalesOrderNo).HasMaxLength(7);
            orderLine.Property(e => e.MasterOrderLineKey).HasMaxLength(6);
            orderLine.Property(e => e.PrintDropShipment);
            orderLine.Property(e => e.MasterOriginalQty).HasColumnType("decimal(16,6)");
            orderLine.Property(e => e.MasterQtyBalance).HasColumnType("decimal(16,6)");
            orderLine.Property(e => e.MasterQtyOrderedToDate).HasColumnType("decimal(16,6)");
            orderLine.Property(e => e.RepeatingQtyShippedToDate).HasColumnType("decimal(16,6)");
            orderLine.ToTable("OrderLines");
        }
    }
}
