using System;
using Microsoft.AspNetCore.Identity;

namespace UBSI_Ops.server.Entities.Identity
{
    public class Role : IdentityRole<int>, IBaseEntity
    {
        public int OrganizationId { get; set; }

        public DateTime CreatedAt { get; private set; }

        public int CreatedById { get; set; }

        public DateTime UpdatedAt { get; private set; }

        public int UpdatedById { get; set; }
    }
}
