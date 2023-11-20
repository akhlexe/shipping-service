using AutoMapper;
using ShippingService.Domain.Entities;

namespace ShippingService.Application.ShipmentOrders.Queries.GetShipmentOrders
{
    public class ShipmentOrderDtoProfile : Profile
    {
        public ShipmentOrderDtoProfile()
        {
            CreateMap<ShipmentOrder, ShipmentOrderDto>();
        }
    }
}
