using System.Text.Json.Serialization;

namespace ChrisKaczor.MinifluxClient.Requests;

public class UpdateEntryRequest
{
    [JsonPropertyName("entry_ids")]
    public required IEnumerable<long> EntryIds { get; set; }

    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required FeedEntryStatus Status { get; set; }
}