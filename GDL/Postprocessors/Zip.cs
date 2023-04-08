using System.Text.Json.Serialization;

namespace GDL.Postprocessors;

public class Zip : Postprocessor
{
    [JsonPropertyName("compression")]
    public string Compression { get; set; } = "store";

    [JsonPropertyName("extension")]
    public string Extension { get; set; } = "zip";

    // TODO: paths
    [JsonPropertyName("files")]
    public IEnumerable<string> Files { get; set; }

    [JsonPropertyName("keep-files")]
    public bool KeepFiles { get; set; }

    [JsonPropertyName("mode")]
    public string Mode { get; set; } = "default";
}
