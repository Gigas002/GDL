using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Aryion : Extractor
{
    [JsonPropertyName("recursive")]
    public bool Recursive { get; set; } = true;
}
