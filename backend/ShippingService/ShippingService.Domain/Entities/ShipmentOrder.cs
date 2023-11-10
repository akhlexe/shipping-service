namespace ShippingService.Domain.Entities
{
    public class ShipmentOrder
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int DepartureAirportId { get; set; }

        public int DestinationAirportId { get; set; }
    }
}
