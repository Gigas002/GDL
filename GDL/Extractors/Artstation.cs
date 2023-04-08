using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Artstation : Extractor
{
    [JsonPropertyName("external")]
    public bool External { get; set; }

    [JsonPropertyName("max-posts")]
    public int MaxPosts { get; set; }

    // TODO: requires custom json converter
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorartstationsearchpro-first
    public bool SearchProFirst { get; set; } = true;
}
