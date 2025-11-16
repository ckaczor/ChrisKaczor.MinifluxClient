using JetBrains.Annotations;
using System.Text.Json.Serialization;

namespace ChrisKaczor.MinifluxClient.Models;

[PublicAPI]
public class Icon
{
    [JsonPropertyName("feed_id")]
    public required long FeedId { get; set; }

    [JsonPropertyName("icon_id")]
    public required long IconId { get; set; }

    [JsonPropertyName("external_icon_id")]
    public required string ExternalIconId { get; set; }
}