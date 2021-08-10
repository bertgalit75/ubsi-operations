using Microsoft.AspNetCore.Authorization;

namespace Ropes.API.Auth
{
    public class AdminOnlyRequirement : IAuthorizationRequirement
    {
    }
}
