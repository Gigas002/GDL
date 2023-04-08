using System.Text.Json.Serialization;

namespace GDL.Downloaders;

public class Downloader : IDownloader
{
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; } = true;
    
    [JsonPropertyName("filesize-min")]
    public string MinFileSize { get; set; }
    
    [JsonPropertyName("filesize-max")]
    public string MaxFileSize { get; set; }

    [JsonPropertyName("mtime")]
    public bool ModificationTime { get; set; } = true;

    [JsonPropertyName("part")]
    public bool Part { get; set; } = true;
    
    [JsonPropertyName("part-directory")]
    public string PartDirectory { get; set; }

    [JsonPropertyName("progress")]
    public double Progress { get; set; } = 3.0;
    
    [JsonPropertyName("rate")]
    public string Rate { get; set; }

    [JsonPropertyName("retries")]
    public int Retries { get; set; } = 4;

    [JsonPropertyName("timeout")]
    public double Timeout { get; set; } = 30.0;
    
    [JsonPropertyName("verify")]
    public string Verify { get; set; }
    
    [JsonPropertyName("proxy")]
    public object Proxy { get; set; }
}
