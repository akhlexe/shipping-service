using ShippingService.Domain.Enums;

namespace ShippingService.Domain.Entities
{
    public class Shipment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public ShipmentState ShipmentState { get; set; }

        public int DepartureAirportId { get; set; }

        public int ArrivalAirportId { get; set; }

        public int ShipmentFlightId { get; set; }

        public DateTime? DeliveredOn { get; set; } 

        public bool IsDelivered { get; set; } = false;

        public ShipmentOrder? Order { get; set; }

        public Flight? ShipmentFlight { get; set; }

        public Airport? DepartureAirport { get; set; }

        public Airport? ArrivalAirport { get; set; }

        //// TODO: Implementar usuarios/personas que se enviaran los paquetes.
        //public string Sender { get; set; } = string.Empty;
        //public string Receiver { get; set; } = string.Empty;
    }
}
