using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Readcomiconline : Extractor
{
    [JsonPropertyName("captcha")]
    public string Captcha { get; set; } = "stop";

    [JsonPropertyName("quality")]
    public string Quality { get; set; } = "auto";
}
