using Microsoft.AspNetCore.Authorization;

namespace Ropes.API.Auth
{
    public class AdminOnlyAttribute : AuthorizeAttribute
    {
        public const string PolicyPrefix = "AdminOnly";

        public AdminOnlyAttribute()
        {
            Policy = PolicyPrefix;
        }
    }
}
