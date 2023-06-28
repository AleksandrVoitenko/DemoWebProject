using Microsoft.EntityFrameworkCore;
using Debtors.Domain;

namespace Debtors.Application.Interfaces
{
    public interface IDebtorsDbContext
    {
        DbSet<Debtor> Debtors { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellation);
    }
}
