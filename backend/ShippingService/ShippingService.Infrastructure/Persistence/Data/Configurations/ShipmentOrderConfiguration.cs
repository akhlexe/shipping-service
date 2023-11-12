using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShippingService.Domain.Entities;

namespace ShippingService.Infrastructure.Persistence.Data.Configurations
{
    public class ShipmentOrderConfiguration : IEntityTypeConfiguration<ShipmentOrder>
    {
        public void Configure(EntityTypeBuilder<ShipmentOrder> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.OriginAirport)
                .WithMany()
                .HasForeignKey(x => x.OriginAirportId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.DestinationAirport)
                .WithMany()
                .HasForeignKey(x => x.DestinationAirportId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
