using Microsoft.AspNetCore.Authorization;

namespace TracklyApi.Models.Auth
{
    // HasScopeRequirement.cs
    public class HasScopeRequirement : IAuthorizationRequirement
    {
        public string Issuer { get; }
        public string Scope { get; }

        public HasScopeRequirement(string scope, string issuer)
        {
            Scope = scope ?? "";
            Issuer = issuer ?? "";
        }
    }
}
