using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Lolisafe : Extractor
{
    [JsonPropertyName("domain")]
    public string Domain { get; set; }
}
