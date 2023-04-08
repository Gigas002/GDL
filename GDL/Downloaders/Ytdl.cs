using System.Text.Json.Serialization;

namespace GDL.Downloaders;

public class Ytdl : Downloader
{
    [JsonPropertyName("format")]
    public string Format { get; set; }

    [JsonPropertyName("forward-cookies")]
    public bool ForwardCookies { get; set; }

    [JsonPropertyName("logging")]
    public bool Logging { get; set; } = true;

    [JsonPropertyName("module")]
    public string Module { get; set; }

    [JsonPropertyName("outtmpl")]
    public string OutputTemplate { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("raw-options")]
    public object RawOptions { get; set; }

    // TODO: list
    [JsonPropertyName("cmdline-args")]
    public string CmdlineArgs { get; set; }

    // TODO: path
    [JsonPropertyName("config-file")]
    public string ConfigFile { get; set; }
}
