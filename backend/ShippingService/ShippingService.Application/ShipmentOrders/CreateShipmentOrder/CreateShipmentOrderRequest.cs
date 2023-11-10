using MediatR;
using ShippingService.Infrastructure.Persistence.Data;

namespace ShippingService.Application.ShipmentOrders.CreateShipmentOrder
{
    public class CreateShipmentOrderRequest : IRequest<CreateShipmentOrderResponse>
    {
        public string Description { get; set; }

        public string DepartureAirportId { get; set; }

        public string DestinationAirportId { get; set; }
    }

    public class CreateShipmentOrderRequestHandler : IRequestHandler<CreateShipmentOrderRequest, CreateShipmentOrderResponse>
    {
        private readonly ApplicationDbContext _context;

        public Task<CreateShipmentOrderResponse> Handle(CreateShipmentOrderRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
