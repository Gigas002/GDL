using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Nana : Extractor
{
    [JsonPropertyName("favkey")]
    public string FavoriteKey { get; set; }
}
