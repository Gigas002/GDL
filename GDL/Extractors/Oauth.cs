using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: should be in Extractor.cs?

// see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractoroauthbrowser

public class Oauth : Extractor
{
    [JsonPropertyName("browser")]
    public bool Browser { get; set; } = true;

    [JsonPropertyName("cache")]
    public bool Cache { get; set; } = true;

    [JsonPropertyName("host")]
    public string Host { get; set; } = "localhost";

    [JsonPropertyName("port")]
    public int Port { get; set; } = 6414;
}
