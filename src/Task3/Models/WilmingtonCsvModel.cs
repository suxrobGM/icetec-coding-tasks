namespace Icetec.Models;

public class WilmingtonCsvModel
{
    public DateTime DateTime { get; set; }
    public int CloudCover { get; set; }
    public string? DayOfWeek { get; set; }
    public string? DayOrNight { get; set; }
    public DateTime ExpirationTimeUtc { get; set; }
    public int IconCode { get; set; }
    public int IconCodeExtend { get; set; }
    public int PrecipChance { get; set; }
    public string? PrecipType { get; set; }
    public double PressureMeanSeaLevel { get; set; }
    public double Qpf { get; set; }
    public double QpfSnow { get; set; }
    public int RelativeHumidity { get; set; }
    public int Temperature { get; set; }
    public int TemperatureDewPoint { get; set; }
    public int TemperatureFeelsLike { get; set; }
    public int TemperatureHeatIndex { get; set; }
    public int TemperatureWindChill { get; set; }
    public string? UvDescription { get; set; }
    public int UvIndex { get; set; }
    public DateTime ValidTimeUtc { get; set; }
    public double Visibility { get; set; }
    public int WindDirection { get; set; }
    public string? WindDirectionCardinal { get; set; }
    public int? WindGust { get; set; }
    public int WindSpeed { get; set; }
    public string? WxPhraseLong { get; set; }
    public string? WxPhraseShort { get; set; }
    public int WxSeverity { get; set; }
}