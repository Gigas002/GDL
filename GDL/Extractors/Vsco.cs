using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Vsco : Extractor
{
    [JsonPropertyName("videos")]
    public bool Videos { get; set; } = true;
}
