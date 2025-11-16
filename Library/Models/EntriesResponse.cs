using JetBrains.Annotations;
using System.Text.Json.Serialization;

namespace ChrisKaczor.MinifluxClient.Models;

[PublicAPI]
public class EntriesResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; set; }

    [JsonPropertyName("entries")]
    public required List<Entry> Entries { get; set; }
}