using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShippingService.Domain.Entities;

namespace ShippingService.Infrastructure.Persistence.Data.Configurations
{
    public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Order)
                .WithMany()
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.DepartureAirport)
                .WithMany()
                .HasForeignKey(x => x.DepartureAirportId) 
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ArrivalAirport)
                .WithMany()
                .HasForeignKey(x => x.ArrivalAirportId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ShipmentFlight)
                .WithMany()
                .HasForeignKey(x => x.ShipmentFlightId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
