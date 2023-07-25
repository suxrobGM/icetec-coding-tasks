namespace Icetec.Models;

public class PrincetonForecast15Minute
{
    public List<int> ValidTimeUtc { get; set; } = new();
    public List<double> IrradianceGlobalHorizontal { get; set; } = new();
    public List<double> IrradianceDirectNormal { get; set; } = new();
}