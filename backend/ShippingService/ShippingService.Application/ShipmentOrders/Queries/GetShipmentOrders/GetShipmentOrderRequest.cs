using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShippingService.Domain.Entities;
using ShippingService.Infrastructure.Persistence.Data;

namespace ShippingService.Application.ShipmentOrders.Queries.GetShipmentOrders
{
    public class GetShipmentOrderRequest : IRequest<IEnumerable<ShipmentOrderDto>> { }

    public class GetShipmentOrderRequestHandler : IRequestHandler<GetShipmentOrderRequest, IEnumerable<ShipmentOrderDto>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetShipmentOrderRequestHandler(
            ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ShipmentOrderDto>> Handle(GetShipmentOrderRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<ShipmentOrder> shipmentOrders = await _context.ShipmentOrders
                .AsNoTracking()
                .ToListAsync();

            return shipmentOrders.Select(x => _mapper.Map<ShipmentOrderDto>(x));
        }
    }
}
