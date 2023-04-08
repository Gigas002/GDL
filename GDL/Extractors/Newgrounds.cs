using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Newgrounds : Extractor
{
    [JsonPropertyName("flash")]
    public bool Flash { get; set; } = true;

    [JsonPropertyName("format")]
    public string Format { get; set; } = "original";

    // TODO: requires custom json converter
    [JsonPropertyName("include")]
    public object Include { get; set; }
}
