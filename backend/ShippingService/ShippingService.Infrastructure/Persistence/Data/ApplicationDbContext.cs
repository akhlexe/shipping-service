using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ShippingService.Domain.Entities;

namespace ShippingService.Infrastructure.Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<ShipmentOrder> ShipmentOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }

    public class DataContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())   
                .AddJsonFile("appsettings.json")
                .Build();

            var dbContextBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            var connectionString = config.GetConnectionString("Default");

            dbContextBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(dbContextBuilder.Options)   ;
        }
    }
}
