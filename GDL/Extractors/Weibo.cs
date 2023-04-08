using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Weibo : Extractor
{
    // TODO: requires custom json converter
    [JsonPropertyName("include")]
    public object Inclide { get; set; }

    [JsonPropertyName("livephoto")]
    public bool Livephoto { get; set; } = true;

    [JsonPropertyName("retweets")]
    public bool Retweets { get; set; } = true;

    [JsonPropertyName("videos")]
    public bool Videos { get; set; } = true;
}
