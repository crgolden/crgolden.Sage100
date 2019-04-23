namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class OrderConfiguration<THeader, TLine> : HeaderConfiguration<THeader, TLine>
        where THeader : Order<TLine>
        where TLine : OrderLine
    {
        public override void Configure(EntityTypeBuilder<THeader> order)
        {
            base.Configure(order);
            order.Property(e => e.MasterRepeatingOrderNo).HasMaxLength(7);
            order.Property(e => e.ShipExpireDate).HasMaxLength(8);
            order.Property(e => e.PrintSalesOrders);
            order.Property(e => e.SalesOrderPrinted);
            order.Property(e => e.PrintPickingSheets);
            order.Property(e => e.PickingSheetPrinted);
            order.Property(e => e.LastInvoiceOrderDate).HasMaxLength(8);
            order.Property(e => e.LastInvoiceOrderNo).HasMaxLength(7);
            order.Property(e => e.CurrentInvoiceNo).HasMaxLength(7);
            order.Property(e => e.CycleCode).HasMaxLength(2);
            order.Property(e => e.CancelReasonCode).HasMaxLength(5);
            order.Property(e => e.CRMProspectID).HasMaxLength(11);
            order.ToTable("Orders");
        }
    }
}
