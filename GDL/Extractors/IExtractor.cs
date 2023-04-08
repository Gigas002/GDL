using GDL.Postprocessors;

namespace GDL.Extractors;

// See: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractor-options

/// <summary>
/// Each extractor is identified by its category and subcategory. The category is the lowercase site name without any spaces or special characters, which is usually just the module name (pixiv, danbooru, ...). The subcategory is a lowercase word describing the general functionality of that extractor (user, favorite, manga, ...).
/// </summary>
public interface IExtractor
{
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorfilename
    // TODO: requires custom json converter
    /// <summary>
    /// A format string to build filenames for downloaded files with.
    /// </summary>
    public object FileName { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractordirectory
    // TODO: requires custom json converter
    /// <summary>
    /// A list of format strings to build target directory paths with.
    /// </summary>
    public IEnumerable<object> Directory { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorbase-directory
    // TODO: path
    /// <summary>
    /// Directory path used as base for all download destinations.
    /// </summary>
    public string BaseDirectory { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorparent-directory
    /// <summary>
    /// Use an extractor's current target directory as base-directory for any spawned child extractors.
    /// </summary>
    public bool ParentDirectory { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorparent-metadata
    // TODO: bool
    /// <summary>
    /// If true, overwrite any metadata provided by a child extractor with its parent's.
    /// If this is a string, add a parent's metadata to its children's to a field named after said string.
    /// </summary>
    public string ParentMetadata { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorparent-skip
    /// <summary>
    ///     Share number of skipped downloads between parent and child extractors.
    /// </summary>
    public bool ParentSkip { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorpath-restrict
    // TODO: requires custom json converter
    /// <summary>
    /// A string of characters to be replaced with the value of path-replace or an object mapping invalid/unwanted characters to their replacements for generated path segment names.
    /// </summary>
    public object PathRestrict { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorpath-replace
    /// <summary>
    /// The replacement character(s) for path-restrict
    /// </summary>
    public string PathReplace { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorpath-remove
    /// <summary>
    /// Set of characters to remove from generated path names.
    /// </summary>
    public string PathRemove { get; set; }
    
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorpath-strip
    /// <summary>
    /// Set of characters to remove from the end of generated path segment names using str.rstrip()
    /// </summary>
    public string PathStrip { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorpath-extended
    /// <summary>
    /// On Windows, use extended-length paths prefixed with \\?\ to work around the 260 characters path length limit.
    /// </summary>
    public bool PathExtended { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorextension-map
    // TODO: requires custom json converter
    /// <summary>
    /// A JSON object mapping filename extensions to their replacements.
    /// </summary>
    public object ExtensionMap { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorskip
    // TODO: bool
    /// <summary>
    /// Controls the behavior when downloading files that have been downloaded before, i.e. a file with the same filename already exists or its ID is in a download archive.
    /// </summary>
    public string Skip { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorsleep
    /// <summary>
    /// Number of seconds to sleep before each download.
    /// </summary>
    public Duration Sleep { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorsleep-extractor
    /// <summary>
    /// Number of seconds to sleep before handling an input URL, i.e. before starting a new extractor.
    /// </summary>
    public Duration SleepExtractor { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorsleep-request
    /// <summary>
    /// Minimal time interval in seconds between each HTTP request during data extraction.
    /// </summary>
    public Duration SleepRequest { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorusername--password
    /// <summary>
    /// The username and password to use when attempting to log in to another site.
    /// </summary>
    public string Username { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorusername--password
    /// <summary>
    /// The username and password to use when attempting to log in to another site.
    /// </summary>
    public string Password { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractornetrc
    /// <summary>
    /// Enable the use of .netrc authentication data.
    /// </summary>
    public bool Netrc { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorcookies
    // TODO: requires custom json converter
    /// <summary>
    /// Source to read additional cookies from.
    /// </summary>
    public object Cookies { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorcookies-update
    /// <summary>
    ///     If extractor.*.cookies specifies the Path of a cookies.txt file and it can be opened and parsed without errors, update its contents with cookies received during data extraction.
    /// </summary>
    public bool CookiesUpdate { get; set; }

    // TODO: requires custom json converter
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorproxy
    /// <summary>
    /// Proxy (or proxies) to be used for remote connections.
    /// </summary>
    public object Proxy { get; set; }

    // TODO: requires custom json converter
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorsource-address
    /// <summary>
    /// Client-side IP address to bind to.
    /// </summary>
    public object SourceAddress { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractoruser-agent
    /// <summary>
    /// User-Agent header value to be used for HTTP requests.
    /// </summary>
    public string UserAgent { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorbrowser
    /// <summary>
    /// Try to emulate a real browser (firefox or chrome) by using their default HTTP headers and TLS ciphers for HTTP requests.
    /// </summary>
    public string Browser { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorheaders
    // TODO: requires custom json converter
    /// <summary>
    /// Additional HTTP headers to be sent with each HTTP request,
    /// </summary>
    public object Headers { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorciphers
    /// <summary>
    /// List of TLS/SSL cipher suites in OpenSSL cipher list format to be passed to ssl.SSLContext.set_ciphers()
    /// </summary>
    public IEnumerable<string> Ciphers { get; set; }

    // TODO: requires custom json converter
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorkeywords
    /// <summary>
    /// Additional name-value pairs to be added to each metadata dictionary.
    /// </summary>
    public object Keywords { get; set; }

    // TODO: requires custom json converter
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorkeywords-default
    /// <summary>
    /// Default value used for missing or undefined keyword names in format strings.
    /// </summary>
    public object KeywordsDefault { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorurl-metadata
    /// <summary>
    /// Insert a file's download URL into its metadata dictionary as the given name.
    /// </summary>
    public string UrlMetadata { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorpath-metadata
    /// <summary>
    /// Insert a reference to the current PathFormat data structure into metadata dictionaries as the given name.
    /// </summary>
    public string PathMetadata { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorhttp-metadata
    /// <summary>
    /// Insert an object containing a file's HTTP headers and filename, extension, and date parsed from them into metadata dictionaries as the given name.
    /// </summary>
    public string HttpMetadata { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorversion-metadata
    /// <summary>
    /// Insert an object containing gallery-dl's version info into metadata dictionaries as the given name.
    /// </summary>
    public string VersionMetadata { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorcategory-transfer
    /// <summary>
    /// ransfer an extractor's (sub)category values to all child extractors spawned by it, to let them inherit their parent's config options.
    /// </summary>
    public bool CategoryTransfer { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorblacklist--whitelist
    /// <summary>
    /// A list of extractor identifiers to ignore (or allow) when spawning child extractors for unknown URLs, e.g. from reddit or plurk.
    /// </summary>
    public IEnumerable<string> Blacklist { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorblacklist--whitelist
    /// <summary>
    /// A list of extractor identifiers to ignore (or allow) when spawning child extractors for unknown URLs, e.g. from reddit or plurk.
    /// </summary>
    public IEnumerable<string> Whitelist { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorarchive
    // TODO: path
    /// <summary>
    /// File to store IDs of downloaded files in. Downloads of files already recorded in this archive file will be skipped.
    /// </summary>
    public string Archive { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorarchive-format
    /// <summary>
    /// An alternative format string to build archive IDs with.
    /// </summary>
    public string ArchiveFormat { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorarchive-prefix
    /// <summary>
    /// Prefix for archive IDs.
    /// </summary>
    public string ArchivePrefix { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorarchive-pragma
    /// <summary>
    /// A list of SQLite PRAGMA statements to run during archive initialization.
    /// </summary>
    public IEnumerable<string> ArchivePragma { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorpostprocessors
    // TODO: probably another class is used
    /// <summary>
    /// A list of post processors to be applied to each downloaded file in the specified order.
    /// </summary>
    public IEnumerable<Postprocessor> Postprocessors { get; set; }

    // see: A list of post processors to be applied to each downloaded file in the specified order.
    // TODO: requires custom json converter
    /// <summary>
    /// Additional Postprocessor Options that get added to each individual post processor object before initializing it and evaluating filters.
    /// </summary>
    public object PostprocessorOptions { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorretries
    /// <summary>
    /// Maximum number of times a failed HTTP request is retried before giving up, or -1 for infinite retries.
    /// </summary>
    public int Retries { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorretry-codes
    /// <summary>
    /// Additional HTTP response status codes to retry an HTTP request on.
    /// </summary>
    public IEnumerable<int> RetryCodes { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractortimeout
    /// <summary>
    /// Amount of time (in seconds) to wait for a successful connection and response from a remote server.
    /// </summary>
    public double Timeout { get; set; }

    // TODO: bool
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorverify
    /// <summary>
    /// Controls whether to verify SSL/TLS certificates for HTTPS requests.
    /// </summary>
    public string Verify { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractordownload
    /// <summary>
    /// Controls whether to download media files.
    /// </summary>
    public bool Download { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorfallback
    /// <summary>
    ///     Use fallback download URLs when a download fails.
    /// </summary>
    public bool Fallback { get; set; }

    // TODO: requires custom json converter
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorimage-range
    /// <summary>
    /// Index range(s) selecting which files to download.
    /// </summary>
    public object ImageRange { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorchapter-range
    /// <summary>
    /// Like image-range, but applies to delegated URLs like manga chapters, etc.
    /// </summary>
    public string ChapterRange { get; set; }

    // TODO: requires custom json converter
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorimage-filter
    /// <summary>
    /// Python expression controlling which files to download.
    /// </summary>
    public object ImageFilter { get; set; }
    
    // TODO: requires custom json converter
    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorchapter-filter
    /// <summary>
    /// Like image-filter, but applies to delegated URLs like manga chapters, etc.
    /// </summary>
    public object ChapterFilter { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorimage-unique
    /// <summary>
    /// Ignore image URLs that have been encountered before during the current extractor run.
    /// </summary>
    public bool ImageUnique { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractorchapter-unique
    /// <summary>
    /// Like image-unique, but applies to delegated URLs like manga chapters, etc.
    /// </summary>
    public bool ChapterUnique { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractordate-format
    /// <summary>
    /// Format string used to parse string values of date-min and date-max.
    /// </summary>
    public string DateFormat { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractormodules
    /// <summary>
    /// List of internal modules to load when searching for a suitable extractor class. Useful to reduce startup time and memory usage.
    /// </summary>
    public IEnumerable<string> Modules { get; set; }

    // see: https://github.com/mikf/gallery-dl/blob/master/docs/configuration.rst#extractormodule-sources
    // TODO: paths
    /// <summary>
    /// List of directories to load external extractor modules from.
    /// </summary>
    public IEnumerable<string> ModuleSources { get; set; }
}
