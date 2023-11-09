using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace ShippingService.Infrastructure.Helpers;

public class CsvDataReader<T,K> 
    where T : class 
    where K : ClassMap<T>
{
    public List<T> ReadDataFromCsv(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            csv.Context.RegisterClassMap<K>();
            return csv.GetRecords<T>().ToList();
        }
    }
}
