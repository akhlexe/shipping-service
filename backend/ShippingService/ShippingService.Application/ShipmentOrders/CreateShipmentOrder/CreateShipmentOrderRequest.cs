using MediatR;
using ShippingService.Domain.Entities;
using ShippingService.Infrastructure.Persistence.Data;

namespace ShippingService.Application.ShipmentOrders.CreateShipmentOrder
{
    public class CreateShipmentOrderRequest : IRequest<CreateShipmentOrderResponse>
    {
        public string Description { get; set; }

        public int OriginAirportId { get; set; }

        public int DestinationAirportId { get; set; }
    }

    public class CreateShipmentOrderRequestHandler : IRequestHandler<CreateShipmentOrderRequest, CreateShipmentOrderResponse>
    {
        private readonly ApplicationDbContext _context;

        public CreateShipmentOrderRequestHandler(ApplicationDbContext context) => _context = context;

        public async Task<CreateShipmentOrderResponse> Handle(CreateShipmentOrderRequest request, CancellationToken cancellationToken)
        {
            ShipmentOrder shipmentOrder = new ShipmentOrder()
            {
                Description = request.Description,
                OriginAirportId = request.OriginAirportId,
                DestinationAirportId = request.DestinationAirportId,
            };

            _context.ShipmentOrders.Add(shipmentOrder);
            await _context.SaveChangesAsync();

            return new CreateShipmentOrderResponse()
            {
                Id = shipmentOrder.Id,
            };
        }
    }
}
