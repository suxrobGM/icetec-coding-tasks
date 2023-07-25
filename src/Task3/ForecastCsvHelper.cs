using System.Globalization;
using CsvHelper;
using Icetec.Models;

namespace Icetec;

public static class ForecastCsvHelper
{
    public static void WritePrincetonData(PrincetonForecast forecast, string outputPath)
    {
        var records = new List<PrincetonCsvModel>();

        for (var i = 0; i < forecast.Forecasts15Minute?.ValidTimeUtc.Count; i++)
        {
            var dateTime = DateTimeOffset.FromUnixTimeSeconds(forecast.Forecasts15Minute.ValidTimeUtc[i]).ToOffset(TimeSpan.FromHours(-5)).DateTime;
            records.Add(new PrincetonCsvModel
            {
                DateTime = dateTime,
                IrradianceGlobalHorizontal = forecast.Forecasts15Minute.IrradianceGlobalHorizontal[i],
                IrradianceDirectNormal = forecast.Forecasts15Minute.IrradianceDirectNormal[i]
            });
        }

        using var writer = new StreamWriter(outputPath);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(records);
    }
    
    public static void WriteWilmingtonData(WilmingtonForecast forecast, string outputPath)
    {
        var records = new List<WilmingtonCsvModel>();

        for (var i = 0; i < forecast.ValidTimeLocal.Count; i++)
        {
            records.Add(new WilmingtonCsvModel
            {
                DateTime = forecast.ValidTimeLocal[i],
                CloudCover = forecast.CloudCover[i],
                DayOfWeek = forecast.DayOfWeek[i],
                DayOrNight = forecast.DayOrNight[i],
                ExpirationTimeUtc = DateTimeOffset.FromUnixTimeSeconds(forecast.ExpirationTimeUtc[i]).UtcDateTime,
                IconCode = forecast.IconCode[i],
                IconCodeExtend = forecast.IconCodeExtend[i],
                PrecipChance = forecast.PrecipChance[i],
                PrecipType = forecast.PrecipType[i],
                PressureMeanSeaLevel = forecast.PressureMeanSeaLevel[i],
                Qpf = forecast.Qpf[i],
                QpfSnow = forecast.QpfSnow[i],
                RelativeHumidity = forecast.RelativeHumidity[i],
                Temperature = forecast.Temperature[i],
                TemperatureDewPoint = forecast.TemperatureDewPoint[i],
                TemperatureFeelsLike = forecast.TemperatureFeelsLike[i],
                TemperatureHeatIndex = forecast.TemperatureHeatIndex[i],
                TemperatureWindChill = forecast.TemperatureWindChill[i],
                UvDescription = forecast.UvDescription[i],
                UvIndex = forecast.UvIndex[i],
                ValidTimeUtc = DateTimeOffset.FromUnixTimeSeconds(forecast.ValidTimeUtc[i]).UtcDateTime,
                Visibility = forecast.Visibility[i],
                WindDirection = forecast.WindDirection[i],
                WindDirectionCardinal = forecast.WindDirectionCardinal[i],
                WindGust = forecast.WindGust[i],
                WindSpeed = forecast.WindSpeed[i],
                WxPhraseLong = forecast.WxPhraseLong[i],
                WxPhraseShort = forecast.WxPhraseShort[i],
                WxSeverity = forecast.WxSeverity[i],
            });
        }

        using var writer = new StreamWriter(outputPath);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(records);
    }
}