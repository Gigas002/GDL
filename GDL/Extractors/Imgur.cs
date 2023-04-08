using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Imgur : Extractor
{
    // TODO: bool
    [JsonPropertyName("mp4")]
    public string Mp4 { get; set; }
}
