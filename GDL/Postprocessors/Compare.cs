using System.Text.Json.Serialization;

namespace GDL.Postprocessors;

public class Compare : Postprocessor
{
    [JsonPropertyName("action")]
    public string Action { get; set; } = "replace";

    [JsonPropertyName("equal")]
    public string Equal { get; set; }
    
    [JsonPropertyName("shallow")]
    public bool Shallow { get; set; }
}
