using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Gfycat : Extractor
{
    // TODO: requires custom json converter
    [JsonPropertyName("format")]
    public object Format { get; set; }
}
