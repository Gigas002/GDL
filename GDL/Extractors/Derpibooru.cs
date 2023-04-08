using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: inherit from Booru?
public class Derpibooru : Extractor
{
    [JsonPropertyName("api-key")]
    public string ApiKey { get; set; }

    [JsonPropertyName("filter")]
    public int Filter { get; set; } = 56027;
}
