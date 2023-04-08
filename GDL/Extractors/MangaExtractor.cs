using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class MangaExtractor : Extractor
{
    [JsonPropertyName("chapter-reverse")]
    public bool ReverseChapter { get; set; }

    [JsonPropertyName("page-reverse")]
    public bool ReversePage { get; set; }
}
