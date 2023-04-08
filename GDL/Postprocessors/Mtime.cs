using System.Text.Json.Serialization;

namespace GDL.Postprocessors;

// TODO: rename class to ModificationTime, but keep Mtime in json

public class Mtime : Postprocessor
{
    [JsonPropertyName("event")]
    public string Event { get; set; } = "file";

    [JsonPropertyName("key")]
    public string Key { get; set; } = "date";

    [JsonPropertyName("value")]
    public string Value { get; set; }
}
