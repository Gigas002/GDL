using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Photobucket : Extractor
{
    [JsonPropertyName("subalbums")]
    public bool Subalbums { get; set; } = true;
}
