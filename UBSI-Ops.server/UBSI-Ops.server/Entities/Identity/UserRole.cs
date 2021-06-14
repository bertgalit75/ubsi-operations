using System;
using Microsoft.AspNetCore.Identity;

namespace UBSI_Ops.server.Entities.Identity
{
    public class UserRole : IdentityUserRole<int>, IBaseEntity
    {
        public DateTime CreatedAt { get; private set; }

        public int CreatedById { get; set; }

        public DateTime UpdatedAt { get; private set; }

        public int UpdatedById { get; set; }
    }
}