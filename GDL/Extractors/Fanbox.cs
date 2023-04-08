using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Fanbox : Extractor
{
    // TODO: bool
    [JsonPropertyName("embeds")]
    public string Embeds { get; set; }
}
