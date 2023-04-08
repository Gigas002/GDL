using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Hitomi : Extractor
{
    [JsonPropertyName("format")]
    public string Format { get; set; } = "webp";
}
