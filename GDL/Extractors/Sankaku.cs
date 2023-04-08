using System.Text.Json.Serialization;

namespace GDL.Extractors;

// TODO: should this be in SankakuComplex?
// TODO: inherit from booru?

public class Sankaku
{
    [JsonPropertyName("refresh")]
    public bool Refresh { get; set; }
}
