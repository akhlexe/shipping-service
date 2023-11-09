namespace ShippingService.Domain.Entities
{
    public class Airport
    {
        public int Id { get; set; }

        public string IataCode { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int Elevation { get; set; }

        public string Continent { get; set; }

        public string IsoCountry { get; set; }

        public string WikipediaLink { get; set; }
    }
}
