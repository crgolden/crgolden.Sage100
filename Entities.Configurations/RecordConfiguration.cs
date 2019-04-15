namespace Clarity.Sage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class RecordConfiguration<T> : IEntityTypeConfiguration<T>
        where T : Record
    {
        public virtual void Configure(EntityTypeBuilder<T> record)
        {
            record.Property(e => e.DateCreated).HasMaxLength(8).IsRequired();
            record.Property(e => e.TimeCreated).HasMaxLength(8).IsRequired();
            record.Property(e => e.UserCreatedKey).HasMaxLength(10).IsRequired();
            record.Property(e => e.DateUpdated).HasMaxLength(8).IsRequired();
            record.Property(e => e.TimeUpdated).HasMaxLength(8).IsRequired();
            record.Property(e => e.UserUpdatedKey).HasMaxLength(10).IsRequired();
        }
    }
}
