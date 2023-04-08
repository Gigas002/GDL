using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Kemonoparty : Extractor
{
    [JsonPropertyName("comments")]
    public bool Comments { get; set; }

    [JsonPropertyName("duplicates")]
    public bool Duplicates { get; set; }

    [JsonPropertyName("dms")]
    public bool Dms { get; set; }

    [JsonPropertyName("favorites")]
    public string Favorites { get; set; } = "artist";

    [JsonPropertyName("files")]
    public IEnumerable<string> Files { get; set; } = new[] { "attachments", "file", "inline" };

    [JsonPropertyName("max-posts")]
    public int MaxPosts { get; set; }

    [JsonPropertyName("metadata")]
    public bool Metadata { get; set; }
}
