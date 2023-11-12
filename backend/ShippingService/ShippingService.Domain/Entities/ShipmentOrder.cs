namespace ShippingService.Domain.Entities
{
    public class ShipmentOrder
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int OriginAirportId { get; set; }

        public int DestinationAirportId { get; set; }

        public Airport OriginAirport { get; set; }

        public Airport DestinationAirport { get; set; }
    }
}
