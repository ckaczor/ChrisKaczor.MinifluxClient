using System.Reflection;

namespace ChrisKaczor.MinifluxClient;

[QueryParameterName("direction")]
public enum SortDirection
{
    [QueryParameterName("asc")]
    Ascending,

    [QueryParameterName("desc")]
    Descending
}

internal static class SortDirectionExtensions
{
    extension(SortDirection)
    {
        internal static string QueryParameterName => typeof(SortDirection).GetCustomAttribute<QueryParameterNameAttribute>()?.Name ?? throw new InvalidOperationException();
    }
}