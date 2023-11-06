using Microsoft.EntityFrameworkCore;
using ShippingService.Domain.Entities;

namespace ShippingService.Infrastructure.Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
