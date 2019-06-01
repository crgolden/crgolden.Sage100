namespace crgolden.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class SalesOrderHeaderConfiguration<THeader, TLine> : RecordConfiguration<THeader>
        where THeader : SalesOrderHeader<TLine>
        where TLine : SalesOrderDetail
    {
        public override void Configure(EntityTypeBuilder<THeader> salesOrderHeader)
        {
            base.Configure(salesOrderHeader);
            salesOrderHeader.HasIndex(e => e.SalesOrderNo);
            salesOrderHeader.Property(e => e.SalesOrderNo).HasMaxLength(7);
            salesOrderHeader.Property(e => e.OrderDate).HasMaxLength(8);
            salesOrderHeader.Property(e => e.OrderType);
            salesOrderHeader.Property(e => e.OrderStatus);
            salesOrderHeader.Property(e => e.MasterRepeatingOrderNo).HasMaxLength(7);
            salesOrderHeader.Property(e => e.ShipExpireDate).HasMaxLength(8);
            salesOrderHeader.Property(e => e.ARDivisionNo).HasMaxLength(2).IsRequired();
            salesOrderHeader.Property(e => e.CustomerNo).HasMaxLength(20).IsRequired();
            salesOrderHeader.Property(e => e.BillToDivisionNo).HasMaxLength(2);
            salesOrderHeader.Property(e => e.BillToCustomerNo).HasMaxLength(20);
            salesOrderHeader.Property(e => e.BillToName).HasMaxLength(30);
            salesOrderHeader.Property(e => e.BillToAddress1).HasMaxLength(30);
            salesOrderHeader.Property(e => e.BillToAddress2).HasMaxLength(30);
            salesOrderHeader.Property(e => e.BillToAddress3).HasMaxLength(30);
            salesOrderHeader.Property(e => e.BillToCity).HasMaxLength(20);
            salesOrderHeader.Property(e => e.BillToState).HasMaxLength(2);
            salesOrderHeader.Property(e => e.BillToZipCode).HasMaxLength(10);
            salesOrderHeader.Property(e => e.BillToCountryCode).HasMaxLength(3);
            salesOrderHeader.Property(e => e.ShipToCode).HasMaxLength(4);
            salesOrderHeader.Property(e => e.ShipToName).HasMaxLength(30);
            salesOrderHeader.Property(e => e.ShipToAddress1).HasMaxLength(30);
            salesOrderHeader.Property(e => e.ShipToAddress2).HasMaxLength(30);
            salesOrderHeader.Property(e => e.ShipToAddress3).HasMaxLength(30);
            salesOrderHeader.Property(e => e.ShipToCity).HasMaxLength(20);
            salesOrderHeader.Property(e => e.ShipToState).HasMaxLength(2);
            salesOrderHeader.Property(e => e.ShipToZipCode).HasMaxLength(10);
            salesOrderHeader.Property(e => e.ShipToCountryCode).HasMaxLength(3);
            salesOrderHeader.Property(e => e.ShipVia).HasMaxLength(15);
            salesOrderHeader.Property(e => e.ShipZone).HasMaxLength(5);
            salesOrderHeader.Property(e => e.ShipZoneActual).HasMaxLength(5);
            salesOrderHeader.Property(e => e.ShipWeight).HasMaxLength(5);
            salesOrderHeader.Property(e => e.CustomerPONo).HasMaxLength(15);
            salesOrderHeader.Property(e => e.FOB).HasMaxLength(15);
            salesOrderHeader.Property(e => e.WarehouseCode).HasMaxLength(3);
            salesOrderHeader.Property(e => e.ConfirmTo).HasMaxLength(30);
            salesOrderHeader.Property(e => e.Comment).HasMaxLength(30);
            salesOrderHeader.Property(e => e.TermsCode).HasMaxLength(2);
            salesOrderHeader.Property(e => e.TaxSchedule).HasMaxLength(9);
            salesOrderHeader.Property(e => e.TaxExemptNo).HasMaxLength(15);
            salesOrderHeader.Property(e => e.InvalidTaxCalc);
            salesOrderHeader.Property(e => e.PrintSalesOrders);
            salesOrderHeader.Property(e => e.SalesOrderPrinted);
            salesOrderHeader.Property(e => e.PrintPickingSheets);
            salesOrderHeader.Property(e => e.PickingSheetPrinted);
            salesOrderHeader.Property(e => e.LastInvoiceOrderDate).HasMaxLength(8);
            salesOrderHeader.Property(e => e.LastInvoiceOrderNo).HasMaxLength(7);
            salesOrderHeader.Property(e => e.CurrentInvoiceNo).HasMaxLength(7);
            salesOrderHeader.Property(e => e.CheckNoForDeposit).HasMaxLength(10);
            salesOrderHeader.Property(e => e.CycleCode).HasMaxLength(2);
            salesOrderHeader.Property(e => e.FaxNo).HasMaxLength(17);
            salesOrderHeader.Property(e => e.BatchFax);
            salesOrderHeader.Property(e => e.BatchEmail);
            salesOrderHeader.Property(e => e.EmailAddress).HasMaxLength(250);
            salesOrderHeader.Property(e => e.FreightCalculationMethod);
            salesOrderHeader.Property(e => e.LotSerialLinesExist);
            salesOrderHeader.Property(e => e.SalespersonDivisionNo).HasMaxLength(2);
            salesOrderHeader.Property(e => e.SalespersonNo).HasMaxLength(4);
            salesOrderHeader.Property(e => e.SplitCommissions);
            salesOrderHeader.Property(e => e.SalespersonDivisionNo2).HasMaxLength(2);
            salesOrderHeader.Property(e => e.SalespersonNo2).HasMaxLength(4);
            salesOrderHeader.Property(e => e.SalespersonDivisionNo3).HasMaxLength(2);
            salesOrderHeader.Property(e => e.SalespersonNo3).HasMaxLength(4);
            salesOrderHeader.Property(e => e.SalespersonDivisionNo4).HasMaxLength(2);
            salesOrderHeader.Property(e => e.SalespersonNo4).HasMaxLength(4);
            salesOrderHeader.Property(e => e.SalespersonDivisionNo5).HasMaxLength(2);
            salesOrderHeader.Property(e => e.SalespersonNo5).HasMaxLength(4);
            salesOrderHeader.Property(e => e.EBMUserType);
            salesOrderHeader.Property(e => e.EBMSubmissionType);
            salesOrderHeader.Property(e => e.EBMUserIDSubmittingThisOrder).HasMaxLength(15);
            salesOrderHeader.Property(e => e.PaymentType).HasMaxLength(5);
            salesOrderHeader.Property(e => e.OtherPaymentTypeRefNo).HasMaxLength(24);
            salesOrderHeader.Property(e => e.PaymentTypeCategory);
            salesOrderHeader.Property(e => e.CancelReasonCode).HasMaxLength(5);
            salesOrderHeader.Property(e => e.RMANo).HasMaxLength(7);
            salesOrderHeader.Property(e => e.JobNo).HasMaxLength(7);
            salesOrderHeader.Property(e => e.ResidentialAddress);
            salesOrderHeader.Property(e => e.CRMUserID).HasMaxLength(11);
            salesOrderHeader.Property(e => e.CRMPersonID).HasMaxLength(11);
            salesOrderHeader.Property(e => e.CRMOpportunityID).HasMaxLength(11);
            salesOrderHeader.Property(e => e.CRMCompanyID).HasMaxLength(11);
            salesOrderHeader.Property(e => e.CRMProspectID).HasMaxLength(11);
            salesOrderHeader.Property(e => e.TaxableSubjectToDiscount).HasColumnType("decimal(13,2)");
            salesOrderHeader.Property(e => e.NonTaxableSubjectToDiscount).HasColumnType("decimal(13,2)");
            salesOrderHeader.Property(e => e.TaxSubjToDiscPrcntOfTotSubjTo).HasColumnType("decimal(7,2)");
            salesOrderHeader.Property(e => e.DiscountRate).HasColumnType("decimal(8,3)");
            salesOrderHeader.Property(e => e.DiscountAmt).HasColumnType("decimal(12,2)");
            salesOrderHeader.Property(e => e.TaxableAmt).HasColumnType("decimal(13,2)");
            salesOrderHeader.Property(e => e.NonTaxableAmt).HasColumnType("decimal(13,2)");
            salesOrderHeader.Property(e => e.SalesTaxAmt).HasColumnType("decimal(12,2)");
            salesOrderHeader.Property(e => e.Weight).HasColumnType("decimal(12,2)");
            salesOrderHeader.Property(e => e.FreightAmt).HasColumnType("decimal(12,2)");
            salesOrderHeader.Property(e => e.DepositAmt).HasColumnType("decimal(13,2)");
            salesOrderHeader.Property(e => e.CommissionRate).HasColumnType("decimal(9,3)");
            salesOrderHeader.Property(e => e.SplitCommRate2).HasColumnType("decimal(9,3)");
            salesOrderHeader.Property(e => e.SplitCommRate3).HasColumnType("decimal(9,3)");
            salesOrderHeader.Property(e => e.SplitCommRate4).HasColumnType("decimal(9,3)");
            salesOrderHeader.Property(e => e.SplitCommRate5).HasColumnType("decimal(9,3)");
            salesOrderHeader.Property(e => e.NumberOfShippingLabels);
            salesOrderHeader.Property(e => e.LastNoOfShippingLabels);
            salesOrderHeader.ToTable("SalesOrderHeaders");
        }
    }
}
