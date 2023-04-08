using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Luscious : Extractor
{
    [JsonPropertyName("gif")]
    public bool Gif { get; set; }
}
