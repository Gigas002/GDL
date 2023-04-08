using System.Text.Json.Serialization;

namespace GDL.Downloaders;

public class Http : Downloader
{
    [JsonPropertyName("adjust-extensions")]
    public bool AdjustExtensions { get; set; } = true;

    // TODO: int
    [JsonPropertyName("chunk-size")]
    public string ChunkSize { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("headers")]
    public object Headers { get; set; }

    [JsonPropertyName("retry-codes")]
    public IEnumerable<int> RetryCodes { get; set; }

    [JsonPropertyName("validate")]
    public bool Validate { get; set; } = true;
}
