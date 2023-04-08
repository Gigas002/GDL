using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Ytdl : Extractor
{
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    [JsonPropertyName("format")]
    public string Format { get; set; }

    [JsonPropertyName("generic")]
    public bool Generic { get; set; } = true;

    [JsonPropertyName("logging")]
    public bool Logging { get; set; } = true;

    [JsonPropertyName("module")]
    public string Module { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("raw-options")]
    public object RawOptions { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("cmdline-args")]
    public object CmdlineArgs { get; set; }

    // TODO: path
    [JsonPropertyName("config-file")]
    public string ConfigFile { get; set; }
}
