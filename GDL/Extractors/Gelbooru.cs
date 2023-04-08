using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: inherit from Booru?
public class Gelbooru : Extractor
{
    [JsonPropertyName("api-key")]
    public string ApiKey { get; set; }

    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
}
