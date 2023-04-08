using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Itaku : Extractor
{
    [JsonPropertyName("videos")]
    public bool Videos { get; set; } = true;
}
