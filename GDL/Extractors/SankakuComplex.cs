using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: inherit from booru?

public class SankakuComplex : Extractor
{
    [JsonPropertyName("embeds")]
    public bool Embeds { get; set; }

    [JsonPropertyName("videos")]
    public bool Videos { get; set; } = true;
}
