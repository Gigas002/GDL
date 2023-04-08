using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Exhentai : Extractor
{
    [JsonPropertyName("domain")]
    public string Domain { get; set; } = "auto";

    [JsonPropertyName("limits")]
    public int Limits { get; set; }

    [JsonPropertyName("metadata")]
    public bool Metadata { get; set; }

    [JsonPropertyName("original")]
    public bool Original { get; set; } = true;

    [JsonPropertyName("source")]
    public string Source { get; set; } = "gallery";
}
