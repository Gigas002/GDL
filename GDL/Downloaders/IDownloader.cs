namespace GDL.Downloaders;

public interface IDownloader
{
    public bool Enabled { get; set; }

    public string MinFileSize { get; set; }

    public string MaxFileSize { get; set; }

    public bool ModificationTime { get; set; }

    public bool Part { get; set; }

    // TODO: path
    public string PartDirectory { get; set; }

    public double Progress { get; set; }

    public string Rate { get; set; }

    public int Retries { get; set; }

    public double Timeout { get; set; }

    // TODO: bool
    public string Verify { get; set; }

    // TODO: requires custom json converter
    public object Proxy { get; set; }
}
