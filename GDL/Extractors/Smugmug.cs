using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Smugmug : Extractor
{
    [JsonPropertyName("videos")]
    public bool Videos { get; set; } = true;

    [JsonPropertyName("api-key")]
    public string ApiKey { get; set; }

    [JsonPropertyName("api-secret")]
    public string ApiSecret { get; set; }
}
