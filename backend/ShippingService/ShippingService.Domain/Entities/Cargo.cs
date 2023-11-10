using ShippingService.Domain.Enums;

namespace ShippingService.Domain.Entities
{
    public class Cargo
    {
        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;

        public int DepartureAirportId { get; set; }

        public int ArrivalAirportId { get; set; }

        public bool IsDelivered { get; set; }

        public DateTime DeliverTime { get; set; }

        public DeliverStateEnum DeliverState { get; set; }

        public Airport? DepartureAirport { get; set; }

        public Airport? ArrivalAirport { get; set; }

        public Flight? Flight { get; set; }

        // TODO: Implementar usuarios/personas que se enviaran los paquetes.
        public string Sender { get; set; } = string.Empty;

        public string Receiver { get; set; } = string.Empty;
    }
}
