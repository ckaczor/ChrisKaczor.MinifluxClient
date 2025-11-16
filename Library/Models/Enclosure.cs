using JetBrains.Annotations;
using System.Text.Json.Serialization;

namespace ChrisKaczor.MinifluxClient.Models;

[PublicAPI]
public class Enclosure
{
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("user_id")]
    public required long UserId { get; set; }

    [JsonPropertyName("entry_id")]
    public required long EntryId { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("mime_type")]
    public required string MimeType { get; set; }

    [JsonPropertyName("size")]
    public required long Size { get; set; }
}