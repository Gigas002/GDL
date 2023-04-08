using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Misskey : Extractor
{
    [JsonPropertyName("renotes")]
    public bool Renotes { get; set; }

    [JsonPropertyName("replies")]
    public bool Replies { get; set; } = true;
}
