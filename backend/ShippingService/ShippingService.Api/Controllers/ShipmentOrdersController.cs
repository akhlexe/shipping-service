using Microsoft.AspNetCore.Mvc;
using ShippingService.Application.ShipmentOrders.Commands.CreateShipmentOrder;
using ShippingService.Application.ShipmentOrders.Queries.GetShipmentOrders;

namespace ShippingService.Api.Controllers
{
    public class ShipmentOrdersController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<CreateShipmentOrderResponse>> CreateShipmentOrderAsync(
            [FromBody] CreateShipmentOrderRequest request)
        {
            CreateShipmentOrderResponse response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShipmentOrderDto>>> GetShipmentOrders()
        {
            IEnumerable<ShipmentOrderDto> response = await Mediator.Send(new GetShipmentOrderRequest());
            return Ok(response);
        }
    }
}