using System.Text.Json.Serialization;

namespace GDL.Extractors;

public class Reddit : Extractor
{
    [JsonPropertyName("comments")]
    public int Comments { get; set; }

    [JsonPropertyName("more-comments")]
    public bool MoreComments { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("date-min")]
    public DateTime MinDate { get; set; }

    // TODO: requires custom json converter
    [JsonPropertyName("date-max")]
    public DateTime MaxDate { get; set; }

    [JsonPropertyName("id-min")]
    public string MinId { get; set; }

    [JsonPropertyName("id-max")]
    public string MaxId { get; set; }

    [JsonPropertyName("recursion")]
    public int Recursion { get; set; }

    [JsonPropertyName("refresh-token")]
    public string RefreshToken { get; set; }

    // TODO: bool
    [JsonPropertyName("videos")]
    public string Videos { get; set; }

    [JsonPropertyName("client-id")]
    public string ClientId { get; set; }

    [JsonPropertyName("user-agent")]
    public string UserAgent { get; set; }
}
