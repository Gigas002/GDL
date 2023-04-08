using System.Text.Json.Serialization;

namespace GDL;

public class Cache
{
    // TODO: path
    [JsonPropertyName("file")]
    public string File { get; set; }
}
