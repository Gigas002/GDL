using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Deviantart : Extractor
{
    [JsonPropertyName("auto-watch")]
    public bool AutoWatch { get; set; }

    [JsonPropertyName("auto-unwatch")]
    public bool AutoUnwatch { get; set; }

    [JsonPropertyName("comments")]
    public bool Comments { get; set; }

    [JsonPropertyName("extra")]
    public bool Extra { get; set; }

    [JsonPropertyName("flat")]
    public bool Flat { get; set; } = true;

    [JsonPropertyName("folders")]
    public bool Folders { get; set; }

    [JsonPropertyName("group")]
    public bool Group { get; set; } = true;

    // TODO: requires custom json converter
    [JsonPropertyName("include")]
    public object Include { get; set; }

    [JsonPropertyName("journals")]
    public string Journals { get; set; } = "html";

    [JsonPropertyName("mature")]
    public bool Mature { get; set; } = true;

    [JsonPropertyName("metadata")]
    public bool Metadata { get; set; } = false;

    // TODO: requires custom json converter
    [JsonPropertyName("original")]
    public object Original { get; set; }

    [JsonPropertyName("pagination")]
    public string Pagination { get; set; } = "api";

    [JsonPropertyName("refresh-token")]
    public string RefreshToken { get; set; }

    [JsonPropertyName("wait-min")]
    public int WaitMin { get; set; }

    [JsonPropertyName("client-id")]
    public string ClientId { get; set; }

    [JsonPropertyName("client-secret")]
    public string ClientSecret { get; set; }
}
