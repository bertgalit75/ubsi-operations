using Microsoft.AspNetCore.Authorization;

namespace UBSI_Ops.server.Auth
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
