using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Bbc : Extractor
{
    [JsonPropertyName("width")]
    public int Width { get; set; } = 1920;
}
