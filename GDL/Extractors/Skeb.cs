using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Skeb : Extractor
{
    [JsonPropertyName("article")]
    public bool Article { get; set; }

    [JsonPropertyName("sent-requests")]
    public bool SentRequests { get; set; }

    [JsonPropertyName("thumbnails")]
    public bool Thumbnails { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("search-filters")]
    public object SearchFilters { get; set; }
}
