using JetBrains.Annotations;
using System.Text.Json.Serialization;

namespace ChrisKaczor.MinifluxClient.Models;

[PublicAPI]
public class Entry
{
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("user_id")]
    public required long UserId { get; set; }

    [JsonPropertyName("feed_id")]
    public required long FeedId { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("hash")]
    public required string Hash { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("comments_url")]
    public required string CommentsUrl { get; set; }

    [JsonPropertyName("published_at")]
    public required DateTimeOffset PublishedAt { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("changed_at")]
    public required DateTimeOffset ChangedAt { get; set; }

    [JsonPropertyName("content")]
    public required string Content { get; set; }

    [JsonPropertyName("author")]
    public required string Author { get; set; }

    [JsonPropertyName("share_code")]
    public required string ShareCode { get; set; }

    [JsonPropertyName("starred")]
    public required bool Starred { get; set; }

    [JsonPropertyName("reading_time")]
    public required int ReadingTime { get; set; }

    [JsonPropertyName("enclosures")]
    public required List<Enclosure> Enclosures { get; set; }

    [JsonPropertyName("feed")]
    public required Feed Feed { get; set; }

    [JsonPropertyName("tags")]
    public required List<string> Tags { get; set; }
}