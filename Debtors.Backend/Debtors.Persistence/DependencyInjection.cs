using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Debtors.Application.Interfaces;

namespace Debtors.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services
            ,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DbConnection");

            services.AddDbContext<DebtorsDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            services.AddScoped<IDebtorsDbContext>(provider =>
                provider.GetService<DebtorsDbContext>());

            return services;
        }
    }
}
