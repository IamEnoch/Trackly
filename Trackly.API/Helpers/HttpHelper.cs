using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TracklyApi.Helpers;

public class HttpHelper
{
    private readonly HttpClient _httpClient;

    public HttpHelper()
    {
        _httpClient = new HttpClient();
    }

    /// <summary>
    /// Http helper for GET requests
    /// </summary>
    /// <typeparam name="TResponse">Response type</typeparam>
    /// <param name="url">URL</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<TResponse> GetAsync<TResponse>(string url, Dictionary<string, string>? headers)
    {
        try
        {
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                }

            }

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Throws exception for non-success status codes

            var responseData = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(responseData);
        }
        catch (HttpRequestException ex)
        {
            throw new Exception($"HTTP GET request failed: {ex.Message}");
        }
    }

    /// <summary>
    /// Http helper for POST requests
    /// </summary>
    /// <typeparam name="TRequest">Request type</typeparam>
    /// <typeparam name="TResponse">Response type</typeparam>
    /// <param name="url">URL string</param>
    /// <param name="postData">post data</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest postData, Dictionary<string, string> headers)
    {
        try
        {
            foreach (var header in headers)
            {
                _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
            } 

            var jsonContent = new StringContent(
                JsonConvert.SerializeObject(postData),
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync(url, jsonContent);
            response.EnsureSuccessStatusCode(); // Throws exception for non-success status codes

            var responseData = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(responseData);
        }
        catch (HttpRequestException ex)
        {
            throw new Exception($"HTTP POST request failed: {ex.Message}");
        }
    }
}
