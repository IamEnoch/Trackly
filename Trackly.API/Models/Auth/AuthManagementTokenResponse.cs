using Newtonsoft.Json;

namespace TracklyApi.Models.Auth;

public class AuthManagementTokenResponse
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }

    [JsonProperty("token_type")]
    public string TokenType { get; set; }
}
