using System.Text.Json;

namespace Jpsmith.Data;

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
    /// <param name="credentials">Authorization name</param>
    /// <param name="content">Object to POST</param>
    /// <returns>Json response content</returns>
    public static async Task<string> CallEndpointAsync(HttpMethod httpMethod, string uri, string credentials, object content)
    {
        using var httpClient = new HttpClient();
        using var httpRequestMessage = new HttpRequestMessage(httpMethod, uri);

        httpClient.DefaultRequestHeaders.Authorization = new("Basic", credentials);

        var json = JsonSerializer.Serialize(content);
        httpRequestMessage.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();

        return responseContent;
    }

    /// <summary>
    /// Asynchronously makes an API request to the given uri
    /// </summary>
    /// <param name="httpMethod">Http method</param>
    /// <param name="uri">Uniform resource identifier</param>
    /// <param name="content">Object to POST</param>
    /// <returns>Json response content</returns>
    public static async Task<string> CallEndpointAsync(HttpMethod httpMethod, string uri, object content)
    {
        using var httpClient = new HttpClient();
        using var httpRequestMessage = new HttpRequestMessage(httpMethod, uri);

        var json = JsonSerializer.Serialize(content);
        httpRequestMessage.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();

        return responseContent;
    }

    /// <summary>
    /// Asynchronously makes an API request to the given uri
    /// </summary>
    /// <param name="httpMethod">Http method</param>
    /// <param name="uri">Uniform resource identifier</param>
    /// <param name="credentials">Authorization name</param>
    /// <returns>Json response content</returns>
    public static async Task<string> CallEndpointAsync(HttpMethod httpMethod, string uri, string credentials)
    {
        using var httpClient = new HttpClient();
        using var httpRequestMessage = new HttpRequestMessage(httpMethod, uri);

        httpClient.DefaultRequestHeaders.Authorization = new("Basic", credentials);

        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();

        return responseContent;
    }

    /// <summary>
    /// Asynchronously makes an API request to the given uri
    /// </summary>
    /// <param name="httpMethod">Http method</param>
    /// <param name="uri">Uniform resource identifier</param>
    /// <returns>Json response content</returns>
    public static async Task<string> CallEndpointAsync(HttpMethod httpMethod, string uri)
    {
        using var httpClient = new HttpClient();
        using var httpRequestMessage = new HttpRequestMessage(httpMethod, uri);

        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();

        return responseContent;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="username"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static string AuthCredentials(string username, string key) => Convert.ToBase64String(Encoding.UTF8.Encode($"{username}:{key}"));
}