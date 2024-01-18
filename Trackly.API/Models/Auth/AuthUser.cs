using Auth0.ManagementApi.Models;
using Newtonsoft.Json;

namespace TracklyApi.Models.Auth;
public class AuthUser
{
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("email_verified")]
    public bool EmailVerified { get; set; }

    [JsonProperty("identities")]
    public AuthUserIdentity[] Identities { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("nickname")]
    public string Nickname { get; set; }

    [JsonProperty("picture")]
    public Uri Picture { get; set; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonProperty("user_id")]
    public string UserId { get; set; }
}
