using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Flickr : Extractor
{
    [JsonPropertyName("access-token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("access-token-secret")]
    public string AccessTokenSecret { get; set; }

    [JsonPropertyName("videos")]
    public bool Videos { get; set; } = true;

    // TODO: int
    [JsonPropertyName("size-max")]
    public string MaxSize { get; set; }

    [JsonPropertyName("api-key")]
    public string ApiKey { get; set; }

    [JsonPropertyName("api-secret")]
    public string ApiSecret { get; set; }
}
