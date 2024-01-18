using Newtonsoft.Json;

namespace TracklyApi.Models.Auth;
public class AuthUserIdentity
{
    [JsonProperty("connection")]
    public string Connection { get; set; }

    [JsonProperty("user_id")]
    public string UserId { get; set; }

    [JsonProperty("provider")]
    public string Provider { get; set; }

    [JsonProperty("isSocial")]
    public bool IsSocial { get; set; }
}
