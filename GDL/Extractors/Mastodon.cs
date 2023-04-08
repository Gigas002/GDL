using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Mastodon : Extractor
{
    [JsonPropertyName("access-token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("reblogs")]
    public bool Reblogs { get; set; }

    [JsonPropertyName("replies")]
    public bool Replies { get; set; } = true;

    [JsonPropertyName("text-posts")]
    public bool TextPosts { get; set; }
}
