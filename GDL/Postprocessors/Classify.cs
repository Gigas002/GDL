using System.Text.Json.Serialization;

namespace GDL.Postprocessors;

public class Classify : Postprocessor
{
    // TODO: requires custom json converter
    [JsonPropertyName("mapping")]
    public object Mapping { get; set; }
}
