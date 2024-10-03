using Newtonsoft.Json;

namespace BlazorHybridMessAround.Models.GoT;

public class GotBooks
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("isbn")]
    public string Isbn { get; set; }

    [JsonProperty("authors")]
    public List<string> Authors { get; set; }

    [JsonProperty("numberOfPages")]
    public int NumberOfPages { get; set; }

    [JsonProperty("publisher")]
    public string Publisher { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("mediaType")]
    public string MediaType { get; set; }

    [JsonProperty("released")]
    public DateTime Released { get; set; }

    [JsonProperty("characters")]
    public List<string> Characters { get; set; }

    [JsonProperty("povCharacters")]
    public List<string> PovCharacters { get; set; }
}
