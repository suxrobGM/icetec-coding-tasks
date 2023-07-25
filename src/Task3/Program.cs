using System.Text.Json;
using Icetec.Models;

namespace Icetec;

internal class Program
{
    public static void Main(string[] argc)
    {
        var princetonData = DeserializeJson<PrincetonForecast>("Princeton(40.35,-74.66)-15min-e.json");
        var wilmingtonData = DeserializeJson<WilmingtonForecast>("Wilmington(39.74,-75.55).json");

        if (princetonData is not null)
        {
            ForecastCsvHelper.WritePrincetonData(princetonData, "Princeton.csv");
        }
        
        if (wilmingtonData is not null)
        {
            ForecastCsvHelper.WriteWilmingtonData(wilmingtonData, "Wilmington.csv");
        }

        Console.WriteLine("Finished!");
        Console.ReadKey();
    }
    
    private static T? DeserializeJson<T>(string filePath) where T : new()
    {
        var jsonData = File.ReadAllText(filePath);
        var serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        serializerOptions.Converters.Add(new CustomDateTimeConverter());
        var result =  JsonSerializer.Deserialize<T>(jsonData, serializerOptions);
        return result;
    }
}