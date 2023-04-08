using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Weasyl : Extractor
{
    [JsonPropertyName("api-key")]
    public string ApiKey { get; set; }

    [JsonPropertyName("metadata")]
    public bool Metadata { get; set; }
}
