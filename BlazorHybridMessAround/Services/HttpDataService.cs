using BlazorHybridMessAround.Utils;
using Microsoft.Net.Http.Headers;
using System.Collections.ObjectModel;

namespace BlazorHybridMessAround.Services;

public class HttpDataService
{
    private readonly HttpClient _httpClient;

    public HttpDataService()
    {
        _httpClient = new HttpClient();

        _httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "*/*");

        _httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "HttpRequestsSample");
    }
    public async Task<T?> GetJsonObject<T>(string url, string parameters = "")
    {
        if (ClientStatus())
        {
            try
            {
                _httpClient.BaseAddress = new Uri(url);
                HttpResponseMessage response = await _httpClient.GetAsync(parameters);
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    return JsonConverterUtil.GetObjectFromJson<T>(responseData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return default;
    }

    public async Task<ObservableCollection<T>?> GetListFromJson<T>(string url, string parameters = "")
    {
        if (ClientStatus())
        {
            try
            {
                _httpClient.BaseAddress = new Uri(url);
                HttpResponseMessage response = await _httpClient.GetAsync(parameters);
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    return JsonConverterUtil.GetListFromJson<T>(responseData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return default;
    }

    private bool ClientStatus()
    {
        return _httpClient != null;
    }
}
