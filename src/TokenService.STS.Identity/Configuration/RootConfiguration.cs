using Skoruba.IdentityServer4.Shared.Configuration.Configuration.Identity;
using TokenService.STS.Identity.Configuration.Interfaces;

namespace TokenService.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}







