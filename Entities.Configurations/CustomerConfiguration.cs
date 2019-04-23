namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class CustomerConfiguration<T>: RecordConfiguration<T> where T : Customer
    {
        public override void Configure(EntityTypeBuilder<T> customer)
        {
            base.Configure(customer);
            customer.HasIndex(e => new { e.ARDivisionNo, e.CustomerNo }).IsUnique();
            customer.Property(e => e.ARDivisionNo).IsRequired().HasMaxLength(2);
            customer.Property(e => e.CustomerNo).IsRequired().HasMaxLength(20);
            customer.Property(e => e.CustomerName).HasMaxLength(30);
            customer.Property(e => e.AddressLine1).HasMaxLength(30);
            customer.Property(e => e.AddressLine2).HasMaxLength(30);
            customer.Property(e => e.AddressLine3).HasMaxLength(30);
            customer.Property(e => e.City).HasMaxLength(20);
            customer.Property(e => e.State).HasMaxLength(2);
            customer.Property(e => e.ZipCode).HasMaxLength(10);
            customer.Property(e => e.CountryCode).HasMaxLength(3);
            customer.Property(e => e.TelephoneNo).HasMaxLength(17);
            customer.Property(e => e.TelephoneExt).HasMaxLength(5);
            customer.Property(e => e.FaxNo).HasMaxLength(17);
            customer.Property(e => e.EmailAddress).HasMaxLength(250);
            customer.Property(e => e.URLAddress).HasMaxLength(50);
            customer.Property(e => e.EBMEnabled);
            customer.Property(e => e.EBMConsumerUserID).HasMaxLength(15);
            customer.Property(e => e.BatchFax);
            customer.Property(e => e.DefaultCreditCardPmtType).HasMaxLength(5);
            customer.Property(e => e.ContactCode).HasMaxLength(10);
            customer.Property(e => e.ShipMethod).HasMaxLength(15);
            customer.Property(e => e.TaxSchedule).HasMaxLength(9);
            customer.Property(e => e.TaxExemptNo).HasMaxLength(15);
            customer.Property(e => e.TermsCode).HasMaxLength(2);
            customer.Property(e => e.SalespersonDivisionNo).HasMaxLength(2);
            customer.Property(e => e.SalespersonNo).HasMaxLength(4);
            customer.Property(e => e.SalespersonDivisionNo2).HasMaxLength(2);
            customer.Property(e => e.SalespersonNo2).HasMaxLength(4);
            customer.Property(e => e.SalespersonDivisionNo3).HasMaxLength(2);
            customer.Property(e => e.SalespersonNo3).HasMaxLength(4);
            customer.Property(e => e.SalespersonDivisionNo4).HasMaxLength(2);
            customer.Property(e => e.SalespersonNo4).HasMaxLength(4);
            customer.Property(e => e.SalespersonDivisionNo5).HasMaxLength(2);
            customer.Property(e => e.SalespersonNo5).HasMaxLength(4);
            customer.Property(e => e.Comment).HasMaxLength(30);
            customer.Property(e => e.SortField).HasMaxLength(10);
            customer.Property(e => e.TemporaryCustomer).HasMaxLength(1);
            customer.Property(e => e.CustomerStatus);
            customer.Property(e => e.InactiveReasonCode).HasMaxLength(5);
            customer.Property(e => e.OpenItemCustomer);
            customer.Property(e => e.ResidentialAddress);
            customer.Property(e => e.StatementCycle);
            customer.Property(e => e.PrintDunningMessage);
            customer.Property(e => e.CustomerType).HasMaxLength(4);
            customer.Property(e => e.PriceLevel);
            customer.Property(e => e.DateLastActivity).HasMaxLength(8);
            customer.Property(e => e.DateLastPayment).HasMaxLength(8);
            customer.Property(e => e.DateLastStatement).HasMaxLength(8);
            customer.Property(e => e.DateLastFinanceChrg).HasMaxLength(8);
            customer.Property(e => e.DateLastAging).HasMaxLength(8);
            customer.Property(e => e.DefaultItemCode).HasMaxLength(30);
            customer.Property(e => e.DefaultCostCode).HasMaxLength(9);
            customer.Property(e => e.DefaultCostType);
            customer.Property(e => e.CreditHold);
            customer.Property(e => e.PrimaryShipToCode).HasMaxLength(4);
            customer.Property(e => e.DateEstablished).HasMaxLength(8);
            customer.Property(e => e.CreditCardGUID).HasMaxLength(32);
            customer.Property(e => e.DefaultPaymentType).HasMaxLength(5);
            customer.Property(e => e.EmailStatements);
            customer.Property(e => e.NumberOfInvToUseInCalc);
            customer.Property(e => e.AvgDaysPaymentInvoice);
            customer.Property(e => e.AvgDaysOverDue);
            customer.Property(e => e.CustomerDiscountRate).HasColumnType("decimal(13,3)");
            customer.Property(e => e.ServiceChargeRate).HasColumnType("decimal(13,3)");
            customer.Property(e => e.CreditLimit).HasColumnType("decimal(14,2)");
            customer.Property(e => e.LastPaymentAmt).HasColumnType("decimal(14,2)");
            customer.Property(e => e.HighestStmntBalance).HasColumnType("decimal(14,2)");
            customer.Property(e => e.UnpaidServiceChrg).HasColumnType("decimal(14,2)");
            customer.Property(e => e.BalanceForward).HasColumnType("decimal(14,2)");
            customer.Property(e => e.CurrentBalance).HasColumnType("decimal(14,2)");
            customer.Property(e => e.AgingCategory1).HasColumnType("decimal(14,2)");
            customer.Property(e => e.AgingCategory2).HasColumnType("decimal(14,2)");
            customer.Property(e => e.AgingCategory3).HasColumnType("decimal(14,2)");
            customer.Property(e => e.AgingCategory4).HasColumnType("decimal(14,2)");
            customer.Property(e => e.OpenOrderAmt).HasColumnType("decimal(14,2)");
            customer.Property(e => e.RetentionCurrent).HasColumnType("decimal(14,2)");
            customer.Property(e => e.RetentionAging1).HasColumnType("decimal(14,2)");
            customer.Property(e => e.RetentionAging2).HasColumnType("decimal(14,2)");
            customer.Property(e => e.RetentionAging3).HasColumnType("decimal(14,2)");
            customer.Property(e => e.RetentionAging4).HasColumnType("decimal(14,2)");
            customer.Property(e => e.SplitCommRate2).HasColumnType("decimal(9,3)");
            customer.Property(e => e.SplitCommRate3).HasColumnType("decimal(9,3)");
            customer.Property(e => e.SplitCommRate4).HasColumnType("decimal(9,3)");
            customer.Property(e => e.SplitCommRate3).HasColumnType("decimal(9,3)");
            customer.Property(e => e.SplitCommRate5).HasColumnType("decimal(9,3)");
            customer.Property(e => e.UseSageCloudForInvPrinting);
            customer.ToTable("Customers");
        }
    }
}
