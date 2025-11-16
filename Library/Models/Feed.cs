using JetBrains.Annotations;
using System.Text.Json.Serialization;

namespace ChrisKaczor.MinifluxClient.Models;

[PublicAPI]
public class Feed
{
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("user_id")]
    public required long UserId { get; set; }

    [JsonPropertyName("feed_url")]
    public required string FeedUrl { get; set; }

    [JsonPropertyName("site_url")]
    public required string SiteUrl { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("checked_at")]
    public required DateTimeOffset CheckedAt { get; set; }

    [JsonPropertyName("next_check_at")]
    public required DateTimeOffset NextCheckAt { get; set; }

    [JsonPropertyName("etag_header")]
    public required string EtagHeader { get; set; }

    [JsonPropertyName("last_modified_header")]
    public required string LastModifiedHeader { get; set; }

    [JsonPropertyName("parsing_error_message")]
    public required string ParsingErrorMessage { get; set; }

    [JsonPropertyName("parsing_error_count")]
    public required int ParsingErrorCount { get; set; }

    [JsonPropertyName("scraper_rules")]
    public required string ScraperRules { get; set; }

    [JsonPropertyName("rewrite_rules")]
    public required string RewriteRules { get; set; }

    [JsonPropertyName("blocklist_rules")]
    public required string BlocklistRules { get; set; }

    [JsonPropertyName("keeplist_rules")]
    public required string KeeplistRules { get; set; }

    [JsonPropertyName("block_filter_entry_rules")]
    public required string BlockFilterEntryRules { get; set; }

    [JsonPropertyName("keep_filter_entry_rules")]
    public required string KeepFilterEntryRules { get; set; }

    [JsonPropertyName("urlrewrite_rules")]
    public required string UrlrewriteRules { get; set; }

    [JsonPropertyName("user_agent")]
    public required string UserAgent { get; set; }

    [JsonPropertyName("cookie")]
    public required string Cookie { get; set; }

    [JsonPropertyName("username")]
    public required string Username { get; set; }

    [JsonPropertyName("password")]
    public required string Password { get; set; }

    [JsonPropertyName("disabled")]
    public required bool Disabled { get; set; }

    [JsonPropertyName("no_media_player")]
    public required bool NoMediaPlayer { get; set; }

    [JsonPropertyName("ignore_http_cache")]
    public required bool IgnoreHttpCache { get; set; }

    [JsonPropertyName("allow_self_signed_certificates")]
    public required bool AllowSelfSignedCertificates { get; set; }

    [JsonPropertyName("fetch_via_proxy")]
    public required bool FetchViaProxy { get; set; }

    [JsonPropertyName("hide_globally")]
    public required bool HideGlobally { get; set; }

    [JsonPropertyName("disable_http2")]
    public required bool DisableHttp2 { get; set; }

    [JsonPropertyName("pushover_enabled")]
    public required bool PushoverEnabled { get; set; }

    [JsonPropertyName("ntfy_enabled")]
    public required bool NtfyEnabled { get; set; }

    [JsonPropertyName("crawler")]
    public required bool Crawler { get; set; }

    [JsonPropertyName("apprise_service_urls")]
    public required string AppriseServiceUrls { get; set; }

    [JsonPropertyName("webhook_url")]
    public required string WebhookUrl { get; set; }

    [JsonPropertyName("ntfy_priority")]
    public required int NtfyPriority { get; set; }

    [JsonPropertyName("ntfy_topic")]
    public required string NtfyTopic { get; set; }

    [JsonPropertyName("pushover_priority")]
    public required int PushoverPriority { get; set; }

    [JsonPropertyName("proxy_url")]
    public required string ProxyUrl { get; set; }

    [JsonPropertyName("category")]
    public required Category Category { get; set; }

    [JsonPropertyName("icon")]
    public required Icon Icon { get; set; }
}