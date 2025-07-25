using Microsoft.AspNetCore.Identity;

namespace BaseApp.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
