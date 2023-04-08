using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Plurk : Extractor
{
    [JsonPropertyName("comments")]
    public bool Comments { get; set; }
}
