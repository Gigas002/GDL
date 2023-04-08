using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Reactor : Extractor
{
    [JsonPropertyName("gif")]
    public bool Gif { get; set; }
}
