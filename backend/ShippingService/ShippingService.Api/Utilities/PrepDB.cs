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

            context.Database.Migrate();
        }
    }
}
