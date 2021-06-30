using Microsoft.AspNetCore.Identity;
using System;

namespace UBSI_Ops.server.Entities.Identity
{
    public class User : IdentityUser<string>
    {
        public string UserId { get; set; }

        public DateTime? EnrolledOn { get; set; }

        public DateTime? LockedOn { get; set; }

        public string Name { get; set; }

    }
}
