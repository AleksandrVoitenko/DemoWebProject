using Microsoft.EntityFrameworkCore;
using Debtors.Application.Interfaces;
using Debtors.Persistence.EntityTypeConfiguration;
using Debtors.Domain.Entities;

namespace Debtors.Persistence
{
    public class DebtorsDbContext : DbContext, IDebtorsDbContext
    {
        public DbSet<Debtor> Debtors { get; set; }
        public DebtorsDbContext(DbContextOptions<DebtorsDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DebtorConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
