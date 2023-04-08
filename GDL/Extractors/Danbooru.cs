using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: inherit from Booru?
public class Danbooru : Extractor
{
    [JsonPropertyName("external")]
    public bool External { get; set; }

    [JsonPropertyName("ugoira")]
    public bool Ugoira { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("metadata")]
    public object Metadata { get; set; }

    // TODO: int
    [JsonPropertyName("threshold")]
    public string Threshold { get; set; }
}
