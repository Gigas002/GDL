namespace GDL.Outputs;

public interface IOutput
{
    // TODO: requires custom json converter
    public object Mode { get; set; }

    // TODO: requires custom json converter
    public object StdOut { get; set; }

    // TODO: requires custom json converter
    public object StdIn { get; set; }

    // TODO: requires custom json converter
    public object StdErr { get; set; }

    public bool Shorten { get; set; }

    // TODO: requires custom json converter
    public object Colors { get; set; }

    public bool Ansi { get; set; }

    public bool Skip { get; set; }

    public bool Fallback { get; set; }

    public bool Private { get; set; }

    // TODO: bool
    public string Progress { get; set; }

    // TODO: requires custom json converter
    public object Log { get; set; }

    // TODO: requires custom json converter
    public object LogFile { get; set; }

    // TODO: requires custom json converter
    public object UnsupportedFile { get; set; }

    public bool NumToStr { get; set; }
}
