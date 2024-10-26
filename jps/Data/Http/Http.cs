namespace Jpsmith.Data.Http;

/// <summary>
/// Contains static methods for making Http requests
/// </summary>
public static class Http
{
    /// <summary>
    /// Asynchronously makes an API request to the given uri
    /// </summary>
    /// <param name="httpMethod">Http method</param>
    /// <param name="uri">Uniform resource identifier</param>
    /// <returns>Json response</returns>
    public static async Task<string> CallEndpointAsync(HttpMethod httpMethod, string uri)
    {
        using var httpClient = new HttpClient();
        using var httpRequestMessage = new HttpRequestMessage(httpMethod, uri);

        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        string json = await httpResponseMessage.Content.ReadAsStringAsync();

        return json;
    }
}