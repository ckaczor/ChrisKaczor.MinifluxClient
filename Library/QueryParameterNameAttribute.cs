namespace ChrisKaczor.MinifluxClient;

[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
internal class QueryParameterNameAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}