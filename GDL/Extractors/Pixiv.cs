using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Pixiv : Extractor
{
    // TODO: requires custom json converter
    [JsonPropertyName("include")]
    public object Include { get; set; }

    [JsonPropertyName("refresh-token")]
    public string RefreshToken { get; set; }

    [JsonPropertyName("metdata")]
    public bool Metadata { get; set; }

    [JsonPropertyName("metadata-bookmark")]
    public bool MetadataBookmark { get; set; }

    // TODO: naming problems
    // [JsonPropertyName("work-related")]
    public bool WorkRelated { get; set; }

    [JsonPropertyName("tags")]
    public string Tags { get; set; } = "japanese";

    [JsonPropertyName("ugoira")]
    public bool Ugoira { get; set; } = true;

    [JsonPropertyName("max-posts")]
    public int MaxPosts { get; set; }
}
