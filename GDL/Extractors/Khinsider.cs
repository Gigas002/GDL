using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Khinsider : Extractor
{
    [JsonPropertyName("format")]
    public string Format { get; set; } = "mp3";
}
