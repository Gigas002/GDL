using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Nijie : Extractor
{
    // TODO: requires custom json converter
    [JsonPropertyName("include")]
    public object Include { get; set; }
}
