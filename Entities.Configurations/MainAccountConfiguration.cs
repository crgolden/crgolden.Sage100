namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class MainAccountConfiguration<T>: RecordConfiguration<T> where T : MainAccount
    {
        public override void Configure(EntityTypeBuilder<T> mainAccount)
        {
            base.Configure(mainAccount);
            mainAccount.HasIndex(e => new { e.SegmentNo, e.MainAccountCode });
            mainAccount.Property(e => e.SegmentNo).HasMaxLength(2).IsRequired();
            mainAccount.Property(e => e.MainAccountCode).HasMaxLength(15);
            mainAccount.Property(e => e.MainAccountDesc).HasMaxLength(40);
            mainAccount.Property(e => e.MainAccountShortDesc).HasMaxLength(20);
            mainAccount.Property(e => e.DateStart).HasMaxLength(8);
            mainAccount.Property(e => e.DateEnd).HasMaxLength(8);
            mainAccount.Property(e => e.Status);
            mainAccount.Property(e => e.ClearBalance);
            mainAccount.Property(e => e.AccountGroup).HasMaxLength(15).IsRequired();
            mainAccount.Property(e => e.AccountCategory);
            mainAccount.Property(e => e.AccountType).HasMaxLength(2).IsRequired();
            mainAccount.Property(e => e.CashFlowsType);
            mainAccount.Property(e => e.RollupCode1).HasMaxLength(20);
            mainAccount.Property(e => e.RollupCode2).HasMaxLength(20);
            mainAccount.Property(e => e.RollupCode3).HasMaxLength(20);
            mainAccount.Property(e => e.RollupCode4).HasMaxLength(20);
            mainAccount.Property(e => e.CompanyCode).HasMaxLength(3).IsRequired();
            mainAccount.ToTable("MainAccounts");
        }
    }
}
