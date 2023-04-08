using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class E621 : Extractor
{
    // TODO: requires custom json converter
    [JsonPropertyName("metadata")]
    public object Metadata { get; set; }

    // TODO: int
    [JsonPropertyName("threshold")]
    public string Threshold { get; set; }
}
