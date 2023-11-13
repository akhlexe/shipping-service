using Microsoft.AspNetCore.Mvc;
using ShippingService.Application.ShipmentOrders.CreateShipmentOrder;

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
    }
}
