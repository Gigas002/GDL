using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Patreon : Extractor
{
    [JsonPropertyName("files")]
    public IEnumerable<string> Files { get; set; }
}
