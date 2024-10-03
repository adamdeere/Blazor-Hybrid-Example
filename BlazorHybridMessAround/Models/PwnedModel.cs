using Newtonsoft.Json;

namespace BlazorHybridMessAround.Models;

public class PwnedModel
{
    [JsonProperty("Name")]
    public string Name { get; set; }

    [JsonProperty("Title")]
    public string Title { get; set; }

    [JsonProperty("Domain")]
    public string Domain { get; set; }

    [JsonProperty("BreachDate")]
    public string BreachDate { get; set; }

    [JsonProperty("AddedDate")]
    public DateTime AddedDate { get; set; }

    [JsonProperty("ModifiedDate")]
    public DateTime ModifiedDate { get; set; }

    [JsonProperty("PwnCount")]
    public int PwnCount { get; set; }

    [JsonProperty("Description")]
    public string Description { get; set; }

    [JsonProperty("LogoPath")]
    public string LogoPath { get; set; }

    [JsonProperty("DataClasses")]
    public List<string> DataClasses { get; set; }

    [JsonProperty("IsVerified")]
    public bool IsVerified { get; set; }

    [JsonProperty("IsFabricated")]
    public bool IsFabricated { get; set; }

    [JsonProperty("IsSensitive")]
    public bool IsSensitive { get; set; }

    [JsonProperty("IsRetired")]
    public bool IsRetired { get; set; }

    [JsonProperty("IsSpamList")]
    public bool IsSpamList { get; set; }

    [JsonProperty("IsMalware")]
    public bool IsMalware { get; set; }

    [JsonProperty("IsSubscriptionFree")]
    public bool IsSubscriptionFree { get; set; }
}



