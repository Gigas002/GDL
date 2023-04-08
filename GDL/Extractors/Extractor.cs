using System.Text.Json.Serialization;
using GDL.Postprocessors;

namespace GDL.Extractors;

/// <inheritdoc/>
public abstract class Extractor : IExtractor
{
    /// <inheritdoc/>
    [JsonPropertyName("filename")]
    public object FileName { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("directory")]
    public IEnumerable<object> Directory { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("base-directory")]
    public string BaseDirectory { get; set; } = "./gallery-dl/";

    /// <inheritdoc/>
    [JsonPropertyName("parent-directory")]
    public bool ParentDirectory { get; set; } = false;

    /// <inheritdoc/>
    // TODO: default
    [JsonPropertyName("parent-metadata")]
    public string ParentMetadata { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("parent-skip")]
    public bool ParentSkip { get; set; } = false;

    /// <inheritdoc/>
    [JsonPropertyName("path-restrict")]
    public object PathRestrict { get; set; } = "auto";

    /// <inheritdoc/>
    [JsonPropertyName("path-replace")]
    public string PathReplace { get; set; } = "_";

    /// <inheritdoc/>
    [JsonPropertyName("path-remove")]
    public string PathRemove { get; set; } = "\u0000-\u001f\u007f";

    /// <inheritdoc/>
    [JsonPropertyName("path-strip")]
    public string PathStrip { get; set; } = "auto";

    /// <inheritdoc/>
    [JsonPropertyName("path-extended")]
    public bool PathExtended { get; set; } = true;
    
    /// <inheritdoc/>
    // TODO: default
    [JsonPropertyName("extension-map")]
    public object ExtensionMap { get; set; }
    
    /// <inheritdoc/>
    // TODO: default
    [JsonPropertyName("skip")]
    public string Skip { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("sleep")]
    public Duration Sleep { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("sleep=extractor")]
    public Duration SleepExtractor { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("sleep-request")]
    public Duration SleepRequest { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("username")]
    public string Username { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("password")]
    public string Password { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("netrc")]
    public bool Netrc { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("cookies")]
    public object Cookies { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("cookies-update")]
    public bool CookiesUpdate { get; set; } = true;
    
    /// <inheritdoc/>
    [JsonPropertyName("proxy")]
    public object Proxy { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("source-address")]
    public object SourceAddress { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("user-agent")]
    public string UserAgent { get; set; } =
        "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:102.0) Gecko/20100101 Firefox/102.0";
    
    /// <inheritdoc/>
    [JsonPropertyName("browser")]
    // TODO: read doc
    public string Browser { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("headers")]
    public object Headers { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("ciphers")]
    public IEnumerable<string> Ciphers { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("keywords")]
    public object Keywords { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("keywords-default")]
    public object KeywordsDefault { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("url-metadata")]
    public string UrlMetadata { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("path-metadata")]
    public string PathMetadata { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("http-metadata")]
    public string HttpMetadata { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("version-metadata")]
    public string VersionMetadata { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("category-transfer")]
    public bool CategoryTransfer { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("blacklist")]
    public IEnumerable<string> Blacklist { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("whitelist")]
    public IEnumerable<string> Whitelist { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("archive")]
    public string Archive { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("archive-format")]
    public string ArchiveFormat { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("archive-prefix")]
    public string ArchivePrefix { get; set; } = "{category}";
    
    /// <inheritdoc/>
    [JsonPropertyName("archive-pragma")]
    public IEnumerable<string> ArchivePragma { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("postprocessors")]
    public IEnumerable<Postprocessor> Postprocessors { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("postprocessor-options")]
    public object PostprocessorOptions { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("retries")]
    public int Retries { get; set; } = 4;
    
    /// <inheritdoc/>
    [JsonPropertyName("retry-codes")]
    public IEnumerable<int> RetryCodes { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("timeout")]
    public double Timeout { get; set; } = 30.0;
    
    /// <inheritdoc/>
    [JsonPropertyName("verify")]
    public string Verify { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("download")]
    public bool Download { get; set; } = true;

    /// <inheritdoc/>
    [JsonPropertyName("fallback")]
    public bool Fallback { get; set; } = true;
    
    /// <inheritdoc/>
    [JsonPropertyName("image-range")]
    public object ImageRange { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("chapter-range")]
    public string ChapterRange { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("image-filter")]
    public object ImageFilter { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("chapter-filter")]
    public object ChapterFilter { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("image-unique")]
    public bool ImageUnique { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("chapter-unique")]
    public bool ChapterUnique { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("date-format")]
    public string DateFormat { get; set; } = "%Y-%m-%dT%H:%M:%S";
    
    /// <inheritdoc/>
    [JsonPropertyName("modules")]
    public IEnumerable<string> Modules { get; set; }
    
    /// <inheritdoc/>
    [JsonPropertyName("module-sources")]
    public IEnumerable<string> ModuleSources { get; set; }
}
