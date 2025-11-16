using ChrisKaczor.MinifluxClient.Models;
using RestSharp;
using System.Text.Json;

namespace ChrisKaczor.MinifluxClient;

public class MinifluxClient
{
    private readonly JsonSerializerOptions _jsonSerializerOptions;
    private readonly RestClient _restClient;

    public MinifluxClient(string url, string apiKey)
    {
        _jsonSerializerOptions = new JsonSerializerOptions();

        _restClient = new RestClient(url);
        _restClient.AddDefaultHeader("X-Auth-Token", apiKey);
    }

    private async Task<T?> ExecuteRestRequest<T>(string api, Method method, IEnumerable<Parameter>? parameters, object? body)
    {
        var request = new RestRequest($"/v1/{api}", method);

        if (parameters != null)
        {
            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter);
            }
        }

        if (body != null)
        {
            var bodyJson = JsonSerializer.Serialize(body, _jsonSerializerOptions);
            request.AddStringBody(bodyJson, DataFormat.Json);
        }

        var response = await _restClient.ExecuteAsync(request);

        if (response == null)
            throw new Exception("Failed to get response from API");

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Error: {response.StatusCode} - {response.Content}");

        if (response.Content == null)
            throw new Exception("Response content is null");

        if (string.IsNullOrWhiteSpace(response.Content))
            return default;

        try
        {
            var responseObject = JsonSerializer.Deserialize<T>(response.Content, _jsonSerializerOptions);

            return responseObject ?? throw new Exception($"Failed to deserialize response content - {response.Content}");
        }
        catch (Exception e)
        {
            throw new Exception($"Failed to deserialize response content - {response.Content}", e);
        }
    }

    public async Task<IEnumerable<Category>> GetCategories()
    {
        var response = await ExecuteRestRequest<IEnumerable<Category>>("categories", Method.Get, null, null);

        return response ?? [];
    }

    public async Task<IEnumerable<Feed>> GetFeeds()
    {
        var response = await ExecuteRestRequest<IEnumerable<Feed>>("feeds", Method.Get, null, null);

        return response ?? [];
    }

    public async Task<IEnumerable<Entry>> GetFeedEntries(long feedId, SortField sortField, SortDirection sortDirection)
    {
        var parameters = new List<Parameter>
        {
            new QueryParameter(SortField.QueryParameterName, sortField.QueryPropertyName),
            new QueryParameter(SortDirection.QueryParameterName, sortDirection.QueryPropertyName)
        };

        var response = await ExecuteRestRequest<EntriesResponse>($"feeds/{feedId}/entries", Method.Get, parameters, null);

        return response?.Entries ?? [];
    }

    public async Task MarkFeedEntries(IEnumerable<long> entryIds, FeedEntryStatus status)
    {
        var updateEntryRequest = new Requests.UpdateEntryRequest
        {
            EntryIds = entryIds,
            Status = status
        };
            
        await ExecuteRestRequest<object>("entries", Method.Put, null, updateEntryRequest);
    }
}