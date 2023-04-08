using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Unsplash : Extractor
{
    [JsonPropertyName("format")]
    public string Format { get; set; } = "raw";
}
