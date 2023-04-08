using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Nitter : Extractor
{
    [JsonPropertyName("quoted")]
    public bool Quoted { get; set; }

    [JsonPropertyName("retweets")]
    public bool Retweets { get; set; }

    // TODO: bool
    [JsonPropertyName("videos")]
    public string Videos { get; set; }
}
