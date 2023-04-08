using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Cyberdrop : Extractor
{
    [JsonPropertyName("domain")]
    public string Domain { get; set; }
}
