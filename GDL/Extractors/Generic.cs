using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: should this be in Extractor.cs?
// see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorgenericenabled
public class Generic : Extractor
{
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}
