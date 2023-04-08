using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Inkbunny : Extractor
{
    [JsonPropertyName("orderby")]
    public string OrderBy { get; set; } = "create_datetime";
}
