using Newtonsoft.Json;

namespace TracklyApi.Models.Auth;
public class UserAuthManagementTokenResponse
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }

    [JsonProperty("scope")]
    public string Scope { get; set; }

    [JsonProperty("expires_in")]
    public long ExpiresIn { get; set; }

    [JsonProperty("token_type")]
    public string TokenType { get; set; }
}
