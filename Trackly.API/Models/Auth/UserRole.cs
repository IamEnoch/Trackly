using Newtonsoft.Json;

namespace TracklyApi.Models.Auth;
public class UserRole
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }
}
