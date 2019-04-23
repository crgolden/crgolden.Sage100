namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class HeaderConfiguration<THeader, TLine> : RecordConfiguration<THeader>
        where THeader : Header<TLine>
        where TLine : Line
    {
        public override void Configure(EntityTypeBuilder<THeader> header)
        {
            base.Configure(header);
            header.Property(e => e.SalesOrderNo).HasMaxLength(7);
            header.Property(e => e.OrderDate).HasMaxLength(8);
            header.Property(e => e.OrderType);
            header.Property(e => e.OrderStatus);
            header.Property(e => e.ARDivisionNo).HasMaxLength(2).IsRequired();
            header.Property(e => e.CustomerNo).HasMaxLength(20).IsRequired();
            header.Property(e => e.BillToDivisionNo).HasMaxLength(2);
            header.Property(e => e.BillToCustomerNo).HasMaxLength(20);
            header.Property(e => e.BillToName).HasMaxLength(30);
            header.Property(e => e.BillToAddress1).HasMaxLength(30);
            header.Property(e => e.BillToAddress2).HasMaxLength(30);
            header.Property(e => e.BillToAddress3).HasMaxLength(30);
            header.Property(e => e.BillToCity).HasMaxLength(20);
            header.Property(e => e.BillToState).HasMaxLength(2);
            header.Property(e => e.BillToZipCode).HasMaxLength(10);
            header.Property(e => e.BillToCountryCode).HasMaxLength(3);
            header.Property(e => e.ShipToCode).HasMaxLength(4);
            header.Property(e => e.ShipToName).HasMaxLength(30);
            header.Property(e => e.ShipToAddress1).HasMaxLength(30);
            header.Property(e => e.ShipToAddress2).HasMaxLength(30);
            header.Property(e => e.ShipToAddress3).HasMaxLength(30);
            header.Property(e => e.ShipToCity).HasMaxLength(20);
            header.Property(e => e.ShipToState).HasMaxLength(2);
            header.Property(e => e.ShipToZipCode).HasMaxLength(10);
            header.Property(e => e.ShipToCountryCode).HasMaxLength(3);
            header.Property(e => e.ShipVia).HasMaxLength(15);
            header.Property(e => e.ShipZone).HasMaxLength(5);
            header.Property(e => e.ShipZoneActual).HasMaxLength(5);
            header.Property(e => e.ShipWeight).HasMaxLength(5);
            header.Property(e => e.CustomerPONo).HasMaxLength(15);
            header.Property(e => e.FOB).HasMaxLength(15);
            header.Property(e => e.WarehouseCode).HasMaxLength(3);
            header.Property(e => e.ConfirmTo).HasMaxLength(30);
            header.Property(e => e.Comment).HasMaxLength(30);
            header.Property(e => e.TermsCode).HasMaxLength(2);
            header.Property(e => e.TaxSchedule).HasMaxLength(9);
            header.Property(e => e.TaxExemptNo).HasMaxLength(15);
            header.Property(e => e.InvalidTaxCalc);
            header.Property(e => e.CheckNoForDeposit).HasMaxLength(10);
            header.Property(e => e.FaxNo).HasMaxLength(17);
            header.Property(e => e.BatchFax);
            header.Property(e => e.BatchEmail);
            header.Property(e => e.EmailAddress).HasMaxLength(250);
            header.Property(e => e.PaymentType).HasMaxLength(5);
            header.Property(e => e.OtherPaymentTypeRefNo).HasMaxLength(24);
            header.Property(e => e.PaymentTypeCategory);
            header.Property(e => e.JobNo).HasMaxLength(7);
            header.Property(e => e.RMANo).HasMaxLength(7);
            header.Property(e => e.CRMUserID).HasMaxLength(11);
            header.Property(e => e.CRMCompanyID).HasMaxLength(11);
            header.Property(e => e.CRMPersonID).HasMaxLength(11);
            header.Property(e => e.CRMOpportunityID).HasMaxLength(11);
            header.Property(e => e.TaxableSubjectToDiscount).HasColumnType("decimal(13,2)");
            header.Property(e => e.NonTaxableSubjectToDiscount).HasColumnType("decimal(13,2)");
            header.Property(e => e.TaxSubjToDiscPrcntOfTotSubjTo).HasColumnType("decimal(7,2)");
            header.Property(e => e.DiscountRate).HasColumnType("decimal(8,3)");
            header.Property(e => e.DiscountAmt).HasColumnType("decimal(12,2)");
            header.Property(e => e.TaxableAmt).HasColumnType("decimal(13,2)");
            header.Property(e => e.NonTaxableAmt).HasColumnType("decimal(13,2)");
            header.Property(e => e.SalesTaxAmt).HasColumnType("decimal(12,2)");
            header.Property(e => e.Weight).HasColumnType("decimal(12,2)");
            header.Property(e => e.FreightAmt).HasColumnType("decimal(12,2)");
            header.Property(e => e.DepositAmt).HasColumnType("decimal(13,2)");
            header.Property(e => e.CommissionRate).HasColumnType("decimal(9,3)");
            header.Property(e => e.SplitCommRate2).HasColumnType("decimal(9,3)");
            header.Property(e => e.SplitCommRate3).HasColumnType("decimal(9,3)");
            header.Property(e => e.SplitCommRate4).HasColumnType("decimal(9,3)");
            header.Property(e => e.SplitCommRate5).HasColumnType("decimal(9,3)");
            header.Property(e => e.NumberOfShippingLabels);
            header.Property(e => e.LastNoOfShippingLabels);
            header.Property(e => e.EBMSubmissionType);
            header.Property(e => e.EBMUserIDSubmittingThisOrder).HasMaxLength(15);
            header.Property(e => e.EBMUserType);
            header.Property(e => e.FreightCalculationMethod);
            header.Property(e => e.LotSerialLinesExist);
            header.Property(e => e.SalespersonDivisionNo).HasMaxLength(2);
            header.Property(e => e.SalespersonNo).HasMaxLength(4);
            header.Property(e => e.SplitCommissions);
            header.Property(e => e.SalespersonDivisionNo2).HasMaxLength(2);
            header.Property(e => e.SalespersonNo2).HasMaxLength(4);
            header.Property(e => e.SalespersonDivisionNo3).HasMaxLength(2);
            header.Property(e => e.SalespersonNo3).HasMaxLength(4);
            header.Property(e => e.SalespersonDivisionNo4).HasMaxLength(2);
            header.Property(e => e.SalespersonNo4).HasMaxLength(4);
            header.Property(e => e.SalespersonDivisionNo5).HasMaxLength(2);
            header.Property(e => e.SalespersonNo5).HasMaxLength(4);
            header.Property(e => e.ResidentialAddress);
        }
    }
}
