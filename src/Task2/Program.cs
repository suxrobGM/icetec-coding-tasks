using System.Globalization;
using CsvHelper;

namespace Icetec;

internal class Program
{
    public static void Main(string[] argc)
    {
        var data = ParseDataFromCSV("rbhs-campus-load-april-2023-data.csv");

        var startDates = data.Select(p => p.Timestamp.Date)
            .Distinct()
            .Where(d => d.Day == 15)
            .OrderBy(d => d)
            .ToList();

        foreach (var startDate in startDates)
        {
            // Filter billing periods
            var endDate = startDate.AddMonths(1);
            var currentBillingPeriodLoads = data.Where(p => 
                    p.Timestamp.Date >= startDate && 
                    p.Timestamp.Date < endDate)
                .ToList();

            // a) Peak demand for the whole billing period
            var allHoursPeak = CalculatePeakHour(currentBillingPeriodLoads);
            
            // b) Peak demand for on-peak hours (7AM-8PM, weekdays)
            var peakHoursData = currentBillingPeriodLoads
                .Where(p => p.Hour is >= 7 and <= 20 && p.Timestamp.DayOfWeek != DayOfWeek.Saturday && p.Timestamp.DayOfWeek != DayOfWeek.Sunday);

            var onPeakHoursPeak = CalculatePeakHour(peakHoursData);

            if (allHoursPeak is not null)
            {
                Console.WriteLine($"a) Billing Period: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}, Max Peak: {allHoursPeak.Timestamp:yyyy-MM-dd} {allHoursPeak.Hour}:00-{allHoursPeak.Hour + 1}:00, Peak Load: {allHoursPeak.PowerLoad:N2} kW");
            }
            
            if (onPeakHoursPeak is not null)
            {
                Console.WriteLine($"b) Billing Period: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}, Max Peak: {onPeakHoursPeak.Timestamp:yyyy-MM-dd} {onPeakHoursPeak.Hour}:00-{onPeakHoursPeak.Hour + 1}:00, Peak Load: {onPeakHoursPeak.PowerLoad:N2} kW");
            }
        }

        Console.WriteLine("Finished!");
        Console.ReadKey();
    }

    private static PowerData? CalculatePeakHour(IEnumerable<PowerData> billingPeriods)
    {
        var peakHour = billingPeriods
            .GroupBy(p => new { p.Timestamp.Date, p.Hour })
            .Select(g => new
            {
                Date = g.Key.Date,
                Hour = g.Key.Hour,
                PeakLoad = g.Max(p => p.PowerLoad)
            })
            .OrderBy(d => d.Date)
            .ThenBy(d => d.Hour)
            .MaxBy(p => p.PeakLoad);

        if (peakHour is null)
            return null;

        return new PowerData
        {
            Timestamp = peakHour.Date,
            Hour = peakHour.Hour,
            PowerLoad = peakHour.PeakLoad
        };
    }

    private static List<PowerData> ParseDataFromCSV(string csvFilePath)
    {
        using var reader = new StreamReader(csvFilePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<PowerDataMap>();
        var records = csv.GetRecords<PowerData>().ToList();
        return records;
    }
}
