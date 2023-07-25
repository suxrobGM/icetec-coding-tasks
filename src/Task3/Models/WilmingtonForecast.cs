namespace Icetec.Models;

public class WilmingtonForecast
{
    public List<int> CloudCover { get; set; } = new();
    public List<string> DayOfWeek { get; set; } = new();
    public List<string> DayOrNight { get; set; } = new();
    public List<int> ExpirationTimeUtc { get; set; } = new();
    public List<int> IconCode { get; set; } = new();
    public List<int> IconCodeExtend { get; set; } = new();
    public List<int> PrecipChance { get; set; } = new();
    public List<string> PrecipType { get; set; } = new();
    public List<double> PressureMeanSeaLevel { get; set; } = new();
    public List<double> Qpf { get; set; } = new();
    public List<double> QpfSnow { get; set; } = new();
    public List<int> RelativeHumidity { get; set; } = new();
    public List<int> Temperature { get; set; } = new();
    public List<int> TemperatureDewPoint { get; set; } = new();
    public List<int> TemperatureFeelsLike { get; set; } = new();
    public List<int> TemperatureHeatIndex { get; set; } = new();
    public List<int> TemperatureWindChill { get; set; } = new();
    public List<string> UvDescription { get; set; } = new();
    public List<int> UvIndex { get; set; } = new();
    public List<DateTime> ValidTimeLocal { get; set; } = new();
    public List<int> ValidTimeUtc { get; set; } = new();
    public List<double> Visibility { get; set; } = new();
    public List<int> WindDirection { get; set; } = new();
    public List<string> WindDirectionCardinal { get; set; } = new();
    public List<int?> WindGust { get; set; } = new();
    public List<int> WindSpeed { get; set; } = new();
    public List<string> WxPhraseLong { get; set; } = new();
    public List<string> WxPhraseShort { get; set; } = new();
    public List<int> WxSeverity { get; set; } = new();
}