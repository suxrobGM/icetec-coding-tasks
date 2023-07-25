using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Icetec;

public class CustomDateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var dateStr = reader.GetString();
        return DateTime.ParseExact(dateStr!, "yyyy-MM-ddTHH:mm:ssK", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("yyyy-MM-ddTHH:mm:ssK"));
    }
}