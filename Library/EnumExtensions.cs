using System.Reflection;

namespace ChrisKaczor.MinifluxClient;

internal static class EnumExtensions
{
    internal static TAttribute? GetAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
    {
        var type = enumValue.GetType();

        var name = Enum.GetName(type, enumValue);

        if (name == null)
            return null;

        var field = type.GetField(name);

        var attribute = field?.GetCustomAttribute<TAttribute>();

        return attribute;
    }

    extension<T>(T value) where T : Enum
    {
        internal string QueryPropertyName => value.GetAttribute<QueryParameterNameAttribute>()?.Name ?? string.Empty;
    }
}