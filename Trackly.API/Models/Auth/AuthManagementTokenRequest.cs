using Newtonsoft.Json;

namespace TracklyApi.Models.Auth;

public class AuthManagementTokenRequest
{
    [JsonProperty("client_id")]
    public string ClientId { get; set; }

    [JsonProperty("client_secret")]
    public string ClientSecret { get; set; }

    [JsonProperty("audience")]
    public Uri Audience { get; set; }

    [JsonProperty("grant_type")]
    public string GrantType { get; set; }
}
