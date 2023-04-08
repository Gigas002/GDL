using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Tumblr : Extractor
{
    [JsonPropertyName("avatar")]
    public bool Avatar { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("date-min")]
    public DateTime MinDate { get; set; }
    
    // TODO: requires custom json converter
    [JsonPropertyName("date-max")]
    public DateTime MaxDate { get; set; }

    [JsonPropertyName("external")]
    public bool External { get; set; }

    [JsonPropertyName("inline")]
    public bool Inline { get; set; } = true;

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("original")]
    public bool Original { get; set; } = true;

    [JsonPropertyName("ratelimit")]
    public string Ratelimit { get; set; } = "abort";

    // TODO: bool
    [JsonPropertyName("reblogs")]
    public string Reblogs { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("posts")]
    public object Posts { get; set; }

    [JsonPropertyName("fallback-delay")]
    public double FallbackDelay { get; set; } = 120.0;

    [JsonPropertyName("fallback-retries")]
    public int FallbackRetries { get; set; } = 2;

    [JsonPropertyName("api-key")]
    public string ApiKey { get; set; }

    [JsonPropertyName("api-secret")]
    public string ApiSecret { get; set; }
}
