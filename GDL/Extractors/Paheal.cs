using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Paheal : Extractor
{
    [JsonPropertyName("metadata")]
    public bool Metadata { get; set; }
}
