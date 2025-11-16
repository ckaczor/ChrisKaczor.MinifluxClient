using ChrisKaczor.MinifluxClient;

namespace Test;

[TestClass]
public sealed class Test
{
    [TestMethod]
    public async Task TestMethod1()
    {
        var client = new MinifluxClient("", "");

        var categories = await client.GetCategories();

        var feeds = await client.GetFeeds();

        foreach (var feed in feeds)
        {
            var feedEntries = await client.GetFeedEntries(feed.Id, SortField.PublishedAt, SortDirection.Descending);
        }
    }
}