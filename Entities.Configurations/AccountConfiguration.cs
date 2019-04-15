namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class AccountConfiguration<T>: RecordConfiguration<T> where T : Account
    {
        public override void Configure(EntityTypeBuilder<T> account)
        {
            account.HasIndex(e => e.AccountKey).IsUnique();
            account.Property(e => e.AccountKey).HasMaxLength(9);
            account.Property(e => e.AccountDesc).HasMaxLength(50);
            account.Property(e => e.FormattedAccount).HasMaxLength(41).IsRequired();
            account.Property(e => e.RawAccount).HasMaxLength(32).IsRequired();
            account.Property(e => e.MainAccountCode).HasMaxLength(15).IsRequired();
            account.Property(e => e.DateStart).HasMaxLength(8);
            account.Property(e => e.DateEnd).HasMaxLength(8);
            account.Property(e => e.Status);
            account.Property(e => e.ClearBalance);
            account.Property(e => e.AccountType).HasMaxLength(2).IsRequired();
            account.Property(e => e.CashFlowsType);
            account.Property(e => e.RollupCode1).HasMaxLength(20);
            account.Property(e => e.RollupCode2).HasMaxLength(20);
            account.Property(e => e.RollupCode3).HasMaxLength(20);
            account.Property(e => e.RollupCode4).HasMaxLength(20);
            account.Property(e => e.AccountGroup).HasMaxLength(15).IsRequired();
            account.Property(e => e.AccountCategory);
            account.Property(e => e.CompanyCode).HasMaxLength(3).IsRequired();
            base.Configure(account);
            account.ToTable("Accounts");
        }
    }
}
