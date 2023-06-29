using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Debtors.Domain.Entities;

namespace Debtors.Persistence.EntityTypeConfiguration
{
    internal class DebtorConfiguration : IEntityTypeConfiguration<Debtor>
    {
        public void Configure(EntityTypeBuilder<Debtor> builder)
        {
            builder.HasKey(debtor => debtor.Id);
            builder.HasIndex(debtor => debtor.Id).IsUnique();
            builder.Property(debtor => debtor.DebtorName).HasMaxLength(100);
            builder.Property(debtor => debtor.DebtorObject).HasMaxLength(100);
            builder.Property(debtor => debtor.Description).HasMaxLength(250);
        }
    }
}
