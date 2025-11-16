using System.Reflection;

namespace ChrisKaczor.MinifluxClient;

[QueryParameterName("order")]
public enum SortField
{
    [QueryParameterName("id")]
    Id,

    [QueryParameterName("status")]
    Status,

    [QueryParameterName("published_at")]
    PublishedAt,

    [QueryParameterName("category_title")]
    CategoryTitle,

    [QueryParameterName("category_id")]
    CategoryId
}

internal static class SortFieldExtensions
{
    extension(SortField)
    {
        internal static string QueryParameterName => typeof(SortField).GetCustomAttribute<QueryParameterNameAttribute>()?.Name ?? throw new InvalidOperationException();
    }
}