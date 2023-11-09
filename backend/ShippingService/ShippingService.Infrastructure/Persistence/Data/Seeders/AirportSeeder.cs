using CsvHelper.Configuration;
using ShippingService.Domain.Entities;
using ShippingService.Infrastructure.Helpers;
using ShippingService.Infrastructure.Persistence.Data.Seeders.Csvs;

namespace ShippingService.Infrastructure.Persistence.Data.Seeders
{
    public class AirportSeeder
    {
        private readonly ApplicationDbContext _context;

        public AirportSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            CsvDataReader<Airport, AirportMap> airportReader = new CsvDataReader<Airport,AirportMap>();
            List<Airport> airports = airportReader.ReadDataFromCsv(CsvPaths.Airports);

            airports.Where(x => !string.IsNullOrEmpty(x.IataCode) && !string.IsNullOrEmpty(x.WikipediaLink))
                .ToList()
                .ForEach(airport =>
                {
                    _context.Airports.Add(airport);
                });

            _context.SaveChanges();
        }
    }

    public class AirportMap : ClassMap<Airport>
    {
        public AirportMap()
        {
            Map(x => x.Type).Index(2);
            Map(x => x.Name).Index(3);
            Map(x => x.Latitude).Index(4);
            Map(x => x.Longitude).Index(5);
            Map(x => x.Continent).Index(7);
            Map(x => x.IsoCountry).Index(8);
            Map(x => x.IataCode).Index(13);
            Map(x => x.WikipediaLink).Index(16);
        }
    }
}
