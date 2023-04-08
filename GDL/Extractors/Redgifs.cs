using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Redgifs
{
    // TODO: requires custom json converter
    [JsonPropertyName("format")]
    public object Format { get; set; }
}
