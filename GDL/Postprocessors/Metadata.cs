using System.Text.Json.Serialization;

namespace GDL.Postprocessors;

public class Metadata : Postprocessor
{
    [JsonPropertyName("mode")]
    public string Mode { get; set; } = "json";

    [JsonPropertyName("filename")]
    public string FileName { get; set; }

    [JsonPropertyName("directory")]
    public string Directory { get; set; } = ".";

    [JsonPropertyName("extension")]
    public string Extension { get; set; } = "json";

    [JsonPropertyName("extension-format")]
    public string ExtensionFormat { get; set; }

    [JsonPropertyName("event")]
    public string Event { get; set; } = "file";

    // TODO: requires custom json converter
    [JsonPropertyName("fields")]
    public object Fields { get; set; }

    // TODO: list
    [JsonPropertyName("content-format")]
    public string ContentFormat { get; set; }

    [JsonPropertyName("ascii")]
    public bool Ascii { get; set; }

    // TODO: int
    [JsonPropertyName("indent")]
    public string Indent { get; set; }

    [JsonPropertyName("separators")]
    public IEnumerable<string> Separators { get; set; } = new[] { ", ", ": " };

    [JsonPropertyName("sort")]
    public bool Sort { get; set; }

    [JsonPropertyName("open")]
    public string Open { get; set; } = "w";

    [JsonPropertyName("encoding")]
    public string Encoding { get; set; } = "utf-8";

    [JsonPropertyName("private")]
    public bool Private { get; set; }

    [JsonPropertyName("skip")]
    public bool Skip { get; set; }

    // TODO: path
    [JsonPropertyName("archive")]
    public string Archive { get; set; }

    [JsonPropertyName("mtime")]
    public bool ModificationTime { get; set; }
}
