using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Booru : Extractor
{
    [JsonPropertyName("tags")]
    public bool Tags { get; set; }

    [JsonPropertyName("notes")]
    public bool Notes { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; } = "file_url";
}
