namespace crgolden.Sage100
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class PurchaseOrderHeaderConfiguration<THeader, TLine> : RecordConfiguration<THeader>
        where THeader : PurchaseOrderHeader<TLine>
        where TLine : PurchaseOrderDetail
    {
        public override void Configure(EntityTypeBuilder<THeader> purchaseOrderHeader)
        {
            base.Configure(purchaseOrderHeader);
            purchaseOrderHeader.HasIndex(e => e.PurchaseOrderNo);
            purchaseOrderHeader.Property(e => e.PurchaseOrderNo).HasMaxLength(7);
            purchaseOrderHeader.Property(e => e.PurchaseOrderDate).HasMaxLength(8);
            purchaseOrderHeader.Property(e => e.OrderType);
            purchaseOrderHeader.Property(e => e.MasterRepeatingOrderNo).HasMaxLength(7);
            purchaseOrderHeader.Property(e => e.RequiredExpireDate).HasMaxLength(8);
            purchaseOrderHeader.Property(e => e.ARDivisionNo).HasMaxLength(2);
            purchaseOrderHeader.Property(e => e.VendorNo).HasMaxLength(7);
            purchaseOrderHeader.Property(e => e.PurchaseName).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.PurchaseAddress1).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.PurchaseAddress2).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.PurchaseAddress3).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.PurchaseCity).HasMaxLength(20);
            purchaseOrderHeader.Property(e => e.PurchaseState).HasMaxLength(2);
            purchaseOrderHeader.Property(e => e.PurchaseZipCode).HasMaxLength(10);
            purchaseOrderHeader.Property(e => e.PurchaseCountryCode).HasMaxLength(3);
            purchaseOrderHeader.Property(e => e.PurchaseAddressCode).HasMaxLength(4);
            purchaseOrderHeader.Property(e => e.ShipToCode).HasMaxLength(4);
            purchaseOrderHeader.Property(e => e.ShipToName).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.ShipToAddress1).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.ShipToAddress2).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.ShipToAddress3).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.ShipToCity).HasMaxLength(20);
            purchaseOrderHeader.Property(e => e.ShipToState).HasMaxLength(2);
            purchaseOrderHeader.Property(e => e.ShipToZipCode).HasMaxLength(10);
            purchaseOrderHeader.Property(e => e.ShipToCountryCode).HasMaxLength(3);
            purchaseOrderHeader.Property(e => e.OrderStatus);
            purchaseOrderHeader.Property(e => e.UseTax);
            purchaseOrderHeader.Property(e => e.PrintPurchaseOrders);
            purchaseOrderHeader.Property(e => e.OnHold);
            purchaseOrderHeader.Property(e => e.BatchFax);
            purchaseOrderHeader.Property(e => e.BatchEmail);
            purchaseOrderHeader.Property(e => e.EmailAddress).HasMaxLength(250);
            purchaseOrderHeader.Property(e => e.CompletionDate).HasMaxLength(8);
            purchaseOrderHeader.Property(e => e.ShipVia).HasMaxLength(15);
            purchaseOrderHeader.Property(e => e.FOB).HasMaxLength(15);
            purchaseOrderHeader.Property(e => e.WarehouseCode).HasMaxLength(3);
            purchaseOrderHeader.Property(e => e.ConfirmTo).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.Comment).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.ARDivisionNo).HasMaxLength(2);
            purchaseOrderHeader.Property(e => e.CustomerNo).HasMaxLength(20);
            purchaseOrderHeader.Property(e => e.TermsCode).HasMaxLength(2);
            purchaseOrderHeader.Property(e => e.LastInvoiceDate).HasMaxLength(8);
            purchaseOrderHeader.Property(e => e.LastInvoiceNo).HasMaxLength(20);
            purchaseOrderHeader.Property(e => e.Form1099);
            purchaseOrderHeader.Property(e => e.Box1099).HasMaxLength(3);
            purchaseOrderHeader.Property(e => e.LastReceiptDate).HasMaxLength(8);
            purchaseOrderHeader.Property(e => e.LastIssueDate).HasMaxLength(8);
            purchaseOrderHeader.Property(e => e.LastPurchaseOrderDate).HasMaxLength(8);
            purchaseOrderHeader.Property(e => e.LastReceiptNo).HasMaxLength(7);
            purchaseOrderHeader.Property(e => e.LastIssueNo).HasMaxLength(7);
            purchaseOrderHeader.Property(e => e.LastPurchaseOrderNo).HasMaxLength(7);
            purchaseOrderHeader.Property(e => e.PrepaidCheckNo).HasMaxLength(10);
            purchaseOrderHeader.Property(e => e.FaxNo).HasMaxLength(17);
            purchaseOrderHeader.Property(e => e.TaxSchedule).HasMaxLength(9);
            purchaseOrderHeader.Property(e => e.InvalidTaxCalc);
            purchaseOrderHeader.Property(e => e.SalesOrderNo).HasMaxLength(7);
            purchaseOrderHeader.Property(e => e.RequisitorName).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.RequisitorDepartment).HasMaxLength(30);
            purchaseOrderHeader.Property(e => e.PrepaidAmt).HasColumnType("decimal(13,2)");
            purchaseOrderHeader.Property(e => e.TaxableAmt).HasColumnType("decimal(13,2)");
            purchaseOrderHeader.Property(e => e.NonTaxableAmt).HasColumnType("decimal(13,2)");
            purchaseOrderHeader.Property(e => e.SalesTaxAmt).HasColumnType("decimal(12,2)");
            purchaseOrderHeader.Property(e => e.FreightAmt).HasColumnType("decimal(12,2)");
            purchaseOrderHeader.Property(e => e.PrepaidFreightAmt).HasColumnType("decimal(12,2)");
            purchaseOrderHeader.Property(e => e.InvoicedAmt).HasColumnType("decimal(13,2)");
            purchaseOrderHeader.Property(e => e.ReceivedAmt).HasColumnType("decimal(13,2)");
            purchaseOrderHeader.Property(e => e.FreightSalesTaxInvAmt).HasColumnType("decimal(13,2)");
            purchaseOrderHeader.Property(e => e.BackOrderLostAmt).HasColumnType("decimal(13,2)");
            purchaseOrderHeader.ToTable("PurchaseOrderHeaders");
        }
    }
}
