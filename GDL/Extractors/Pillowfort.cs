using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Pillowfort : Extractor
{
    [JsonPropertyName("external")]
    public bool External { get; set; }

    [JsonPropertyName("inline")]
    public bool Inline { get; set; } = true;

    [JsonPropertyName("reblogs")]
    public bool Reblogs { get; set; }
}
