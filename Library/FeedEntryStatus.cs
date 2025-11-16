using System.Text.Json.Serialization;

namespace ChrisKaczor.MinifluxClient;

public enum FeedEntryStatus
{
    [JsonStringEnumMemberName("read")]
    Read,

    [JsonStringEnumMemberName("unread")]
    Unread
}