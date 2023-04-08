using System.Text.Json.Serialization;

namespace GDL.Postprocessors;

public class Exec : Postprocessor
{
    // TODO: path
    [JsonPropertyName("archive")]
    public string Archive { get; set; }

    [JsonPropertyName("async")]
    public bool Async { get; set; }

    // TODO: list
    [JsonPropertyName("command")]
    public string Command { get; set; }

    [JsonPropertyName("event")]
    public string Event { get; set; } = "after";
}
