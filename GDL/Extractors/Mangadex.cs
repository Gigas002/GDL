using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Mangadex : Extractor
{
    [JsonPropertyName("api-server")]
    public string ApiServer { get; set; } = "https://api.mangadex.org";

    // TODO: requires custom json converter
    [JsonPropertyName("api-parameters")]
    public object ApiParameters { get; set; }

    [JsonPropertyName("lang")]
    public string Language { get; set; }

    [JsonPropertyName("ratings")]
    public IEnumerable<string> Ratings { get; set; } = new[] { "safe", "suggestive", "erotica", "pornographic" };
}
