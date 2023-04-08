using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Furaffinity : Extractor
{
    [JsonPropertyName("descriptions")]
    public string Descriptions { get; set; } = "text";

    [JsonPropertyName("external")]
    public bool External { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("include")]
    public object Include { get; set; }

    [JsonPropertyName("layout")]
    public string Layout { get; set; } = "auto";
}
