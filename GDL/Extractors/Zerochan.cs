using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: inherit from booru?

public class Zerochan : Extractor
{
    [JsonPropertyName("metadata")]
    public bool Metadata { get; set; }
}
