using CsvHelper.Configuration;

namespace Icetec;

public sealed class PowerDataMap : ClassMap<PowerData>
{
    public PowerDataMap()
    {
        Map(i => i.Timestamp).Name("Timestamp");
        Map(i => i.Hour).Name("HR");
        Map(i => i.PowerLoad).Name("RBHS.Power.Campus_Load_kW:5min");
    }
}
