namespace ShippingService.Domain.Entities
{
    public class Airport
    {
        public int Id { get; set; }

        public string IATA_Code { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string Continent { get; set; }

        public string CountryCode { get; set; }
    }
}
