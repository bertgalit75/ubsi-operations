using Microsoft.AspNetCore.Identity;
using System;

namespace UBSI_Ops.server.Entities.Identity
{
    public class User : IdentityUser<string>
    {
        public DateTime? EnrolledOn { get; set; }

        public DateTime? LockedOn { get; set; }

        public string Name { get; set; }

        internal object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        //public int UserRoleId { get; set; }

        //public UserRole UserRole { get; set; }
    }
}
