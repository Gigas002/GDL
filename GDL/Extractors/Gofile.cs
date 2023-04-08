using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Gofile : Extractor
{
    [JsonPropertyName("api-token")]
    public string ApiToken { get; set; }

    [JsonPropertyName("website-token")]
    public string WebsiteToken { get; set; } = "12345";

    [JsonPropertyName("recursive")]
    public bool Recursive { get; set; }
}
