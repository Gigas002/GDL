using System.Text.Json.Serialization;

namespace GDL.Outputs;

public class Output : IOutput
{
    [JsonPropertyName("mode")]
    public object Mode { get; set; }
    
    [JsonPropertyName("stdout")]
    public object StdOut { get; set; }
    
    [JsonPropertyName("stdin")]
    public object StdIn { get; set; }
    
    [JsonPropertyName("stderr")]
    public object StdErr { get; set; }

    [JsonPropertyName("shorten")]
    public bool Shorten { get; set; } = true;
    
    [JsonPropertyName("colors")]
    public object Colors { get; set; }
    
    [JsonPropertyName("ansi")]
    public bool Ansi { get; set; }

    [JsonPropertyName("skip")]
    public bool Skip { get; set; } = true;

    [JsonPropertyName("fallback")]
    public bool Fallback { get; set; } = true;
    
    [JsonPropertyName("private")]
    public bool Private { get; set; }
    
    [JsonPropertyName("progress")]
    public string Progress { get; set; }
    
    [JsonPropertyName("log")]
    public object Log { get; set; }
    
    [JsonPropertyName("logfile")]
    public object LogFile { get; set; }
    
    [JsonPropertyName("unsupportedfile")]
    public object UnsupportedFile { get; set; }
    
    [JsonPropertyName("num-to-str")]
    public bool NumToStr { get; set; }
}
