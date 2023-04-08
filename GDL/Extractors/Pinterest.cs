using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Pinterest : Extractor
{
    [JsonPropertyName("domain")]
    public string Domain { get; set; } = "auto";

    [JsonPropertyName("sections")]
    public bool Sections { get; set; } = true;

    [JsonPropertyName("videos")]
    public bool Videos { get; set; } = true;
}
