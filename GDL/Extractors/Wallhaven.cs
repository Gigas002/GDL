using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Wallhaven : Extractor
{
    [JsonPropertyName("api-key")]
    public string ApiKey { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("include")]
    public object Include { get; set; }

    [JsonPropertyName("metadata")]
    public bool Metadata { get; set; }
}
