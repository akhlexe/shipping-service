using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShippingService.Infrastructure.Persistence.Data;

namespace ShippingService.Api.Utilities
{
    public class PrepDB
    {
        public static void Migrate(IApplicationBuilder builder)
        {

            using var scope = builder.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            bool isProcessing = true;

            while(isProcessing)
            {
                try
                {
                    context.Database.Migrate();
                    DataSeeder.SeedData(builder.ApplicationServices);
                    break;
                }
                catch(SqlException ex)
                {
                    Task.Delay(TimeSpan.FromSeconds(5)).Wait();
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
