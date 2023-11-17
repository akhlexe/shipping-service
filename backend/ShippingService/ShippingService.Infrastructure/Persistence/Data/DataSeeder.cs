using Microsoft.Extensions.DependencyInjection;
using ShippingService.Infrastructure.Persistence.Data.Seeders;

namespace ShippingService.Infrastructure.Persistence.Data
{
    public static class DataSeeder
    {
        public static void SeedData(IServiceProvider serviceProvider)
        {
            using(var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                ApplicationDbContext? context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                if (!context.Airports.Any())
                {
                    new AirportSeeder(context).SeedData();
                }
            }
        }
    }
}
