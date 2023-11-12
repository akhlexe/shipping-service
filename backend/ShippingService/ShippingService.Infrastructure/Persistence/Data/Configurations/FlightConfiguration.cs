using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShippingService.Domain.Entities;

namespace ShippingService.Infrastructure.Persistence.Data.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.DepartureAirport)
                .WithMany()
                .HasForeignKey(x => x.DepartureAirportId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.DepartureAirportId)
                .IsRequired();

            builder.HasOne(x => x.ArrivalAirport)
                .WithMany()
                .HasForeignKey(x => x.ArrivalAirportId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.ArrivalAirport)
                .IsRequired();

            builder.Property(x => x.DepartureTime)
                .IsRequired();

            builder.Property(x => x.ArrivalTime)
                .IsRequired();
        }
    }
}
