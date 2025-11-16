using JetBrains.Annotations;
using System.Text.Json.Serialization;

namespace ChrisKaczor.MinifluxClient.Models;

[PublicAPI]
public class Category
{
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("user_id")]
    public required long UserId { get; set; }

    [JsonPropertyName("hide_globally")]
    public required bool HideGlobally { get; set; }
}