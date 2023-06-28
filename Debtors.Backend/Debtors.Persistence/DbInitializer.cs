
namespace Debtors.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(DebtorsDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
