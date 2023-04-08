using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Twitter : Extractor
{
    // TODO: bool
    [JsonPropertyName("cards")]
    public string Cards { get; set; }

    [JsonPropertyName("cards-blacklist")]
    public IEnumerable<string> CardsBlacklist { get; set; }

    [JsonPropertyName("conversations")]
    public bool Conversations { get; set; }

    [JsonPropertyName("csrf")]
    public string CrossSiteRequestForgery { get; set; } = "cookies";

    [JsonPropertyName("expand")]
    public bool Expand { get; set; }

    [JsonPropertyName("transform")]
    public bool Transform { get; set; } = true;

    [JsonPropertyName("size")]
    public IEnumerable<string> Size { get; set; } = new[] { "orig", "4096x4096", "large", "medium", "small" };

    // TODO: bool
    [JsonPropertyName("syndication")]
    public string Syndication { get; set; }

    [JsonPropertyName("logout")]
    public bool Logout { get; set; }

    [JsonPropertyName("pinned")]
    public bool Pinned { get; set; }

    [JsonPropertyName("quoted")]
    public bool Quoted { get; set; }

    [JsonPropertyName("replies")]
    public bool Replies { get; set; } = true;

    [JsonPropertyName("retweets")]
    public bool Retweets { get; set; }

    // TODO: naming problems
    // [JsonPropertyName("videos")]
    public string TimelineStrategy { get; set; } = "auto";

    [JsonPropertyName("text-tweets")]
    public bool TextTweets { get; set; }

    [JsonPropertyName("twitpic")]
    public bool TwitPic { get; set; }

    [JsonPropertyName("unique")]
    public bool Unique { get; set; } = true;

    [JsonPropertyName("users")]
    public string Users { get; set; } = "timeline";

    // TODO: bool
    [JsonPropertyName("videos")]
    public string Videos { get; set; }
}
