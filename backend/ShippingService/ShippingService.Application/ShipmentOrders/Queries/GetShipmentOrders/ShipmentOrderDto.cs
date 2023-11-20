namespace ShippingService.Application.ShipmentOrders.Queries.GetShipmentOrders;

public record ShipmentOrderDto
{
    public int Id { get; init; }
    public string Description { get; init; }
    public int OriginAirportId { get; init; }
    public int DestinationAirportId { get; init; }
}
