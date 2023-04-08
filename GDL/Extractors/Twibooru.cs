using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: inherit from booru?

public class Twibooru : Extractor
{
    [JsonPropertyName("api-key")]
    public string ApiKey { get; set; }

    [JsonPropertyName("filter")]
    public int Filter { get; set; } = 2;
}
