using System.Text.Json.Serialization;

namespace GDL.Postprocessors;

public class Ugoira : Postprocessor
{
    [JsonPropertyName("extension")]
    public string Extension { get; set; } = "webm";

    [JsonPropertyName("ffmpeg-args")]
    public IEnumerable<string> FfmpegArgs { get; set; }

    [JsonPropertyName("ffmpeg-demuxer")]
    public string FfmpegDemuxer { get; set; } = "auto";

    [JsonPropertyName("ffmpeg-location")]
    public string FfmpegLocation { get; set; } = "ffmpeg";

    // TODO: path
    [JsonPropertyName("mkvmerge-location")]
    public string MkvmergeLocation { get; set; } = "mkvmerge";

    [JsonPropertyName("ffmpeg-output")]
    public bool FfmpegOutput { get; set; } = true;

    [JsonPropertyName("ffmpeg-twopass")]
    public bool FfmpegTwopass { get; set; }

    [JsonPropertyName("framerate")]
    public string Framerate { get; set; } = "auto";

    [JsonPropertyName("keep-files")]
    public bool KeepFiles { get; set; }

    [JsonPropertyName("libx264-prevent-odd")]
    public bool Libx264PreventOdd { get; set; } = true;

    [JsonPropertyName("mtime")]
    public bool ModificationTime { get; set; } = true;

    [JsonPropertyName("repeat-last-frame")]
    public bool RepeatLastFrame { get; set; } = true;
}
