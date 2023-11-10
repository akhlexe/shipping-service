using ShippingService.Domain.Enums;

namespace ShippingService.Domain.Entities
{
    public class Flight
    {
        public int Id { get; set; }

        public int DepartureAirportId { get; set; }

        public DateTime DepartureTime { get; set; }

        public int ArrivalAirportId { get; set; }
        
        public DateTime ArrivalTime { get; set; }

        public FlightStateEnum FlightState { get; set; }

        public Airport DepartureAirport { get; set; }

        public Airport ArrivalAirport { get; set; }
    }
}
