namespace Icetec.Models;

public class PrincetonForecastMetadata
{
    public int ProcTime { get; set; }
    public string? Units { get; set; }
    public double ServiceTime { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public int InitTimeUtc { get; set; }
    public double Elevation { get; set; }
    public int Landuse { get; set; }
    public string? Resource { get; set; }
    public string? Version { get; set; }
    public long RequestId { get; set; }
}