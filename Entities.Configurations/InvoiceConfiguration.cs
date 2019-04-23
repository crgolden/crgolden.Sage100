namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class InvoiceConfiguration<THeader, TLine> : HeaderConfiguration<THeader, TLine>
        where THeader : Invoice<TLine>
        where TLine : InvoiceLine
    {
        public override void Configure(EntityTypeBuilder<THeader> invoice)
        {
            base.Configure(invoice);
            invoice.Property(e => e.InvoiceNo).HasMaxLength(7);
            invoice.Property(e => e.InvoiceDate).HasMaxLength(8);
            invoice.Property(e => e.InvoiceType).HasMaxLength(2);
            invoice.Property(e => e.ShipDate).HasMaxLength(8);
            invoice.Property(e => e.PrintInvoice);
            invoice.Property(e => e.InvoicePrinted);
            invoice.Property(e => e.AcceptCashOnly);
            invoice.Property(e => e.CustomerType).HasMaxLength(4);
            invoice.Property(e => e.ApplyToInvoiceNo).HasMaxLength(7);
            invoice.Property(e => e.InvoiceDueDate).HasMaxLength(8);
            invoice.Property(e => e.DiscountDueDate).HasMaxLength(8);
            invoice.Property(e => e.BatchNo).HasMaxLength(5);
            invoice.Property(e => e.EMailUpdateFlagForRestart);
            invoice.Property(e => e.OrderChangedInShipping);
            invoice.Property(e => e.LinesChangedInShipping);
            invoice.Property(e => e.ShipperID).HasMaxLength(3);
            invoice.Property(e => e.ShipStatus);
            invoice.Property(e => e.StarshipFreightUsed);
            invoice.Property(e => e.StarshipRecordsCreated);
            invoice.Property(e => e.InvalidWarrantyCode);
            invoice.Property(e => e.RetentionAmt).HasColumnType("decimal(13,2)");
            invoice.Property(e => e.TotalSubjectToComm).HasColumnType("decimal(13,2)");
            invoice.Property(e => e.CommissionRate).HasColumnType("decimal(9,3)");
            invoice.Property(e => e.CommissionAmt).HasColumnType("decimal(12,2)");
            invoice.Property(e => e.OverrideCommAmt).HasColumnType("decimal(12,2)");
            invoice.Property(e => e.CostOfGoodsSoldAmt).HasColumnType("decimal(13,2)");
            invoice.Property(e => e.CostOfGoodsSoldSubjToComm).HasColumnType("decimal(13,2)");
            invoice.Property(e => e.SIShippedLinesCOGS).HasColumnType("decimal(13,2)");
            invoice.Property(e => e.NumberOfCODLabels);
            invoice.Property(e => e.NumberOfBackOrderLines);
            invoice.Property(e => e.NumberofPackages);
            invoice.ToTable("Invoices");
        }
    }
}
