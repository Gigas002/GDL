using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: inherit from booru?

public class Szurubooru : Extractor
{
    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("token")]
    public string Token { get; set; }
}
