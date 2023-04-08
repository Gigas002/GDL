using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Instagram : Extractor
{
    [JsonPropertyName("api")]
    public string Api { get; set; } = "rest";

    // TODO: requires custom json converter
    [JsonPropertyName("include")]
    public object Include { get; set; }

    [JsonPropertyName("previews")]
    public bool Previews { get; set; }

    [JsonPropertyName("videos")]
    public bool Videos { get; set; } = true;
}
