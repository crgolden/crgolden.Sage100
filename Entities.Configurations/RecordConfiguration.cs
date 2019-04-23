namespace Clarity.Sage
{
    using Abstractions;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class RecordConfiguration<T> : EntityConfiguration<T>
        where T : Record
    {
        public override void Configure(EntityTypeBuilder<T> record)
        {
            base.Configure(record);
            record.Property(e => e.DateCreated).HasMaxLength(8).IsRequired();
            record.Property(e => e.TimeCreated).HasMaxLength(8).IsRequired();
            record.Property(e => e.UserCreatedKey).HasMaxLength(10).IsRequired();
            record.Property(e => e.DateUpdated).HasMaxLength(8).IsRequired();
            record.Property(e => e.TimeUpdated).HasMaxLength(8).IsRequired();
            record.Property(e => e.UserUpdatedKey).HasMaxLength(10).IsRequired();
        }
    }
}
