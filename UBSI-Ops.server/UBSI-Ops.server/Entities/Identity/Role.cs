using Microsoft.AspNetCore.Identity;
using System;
namespace UBSI_Ops.server.Entities.Identity
{
    public class Role : IdentityRole<int>
    {
        public int OrganizationId { get; set; }

        public DateTime CreatedAt { get; private set; }

        public string CreatedById { get; set; }

        public DateTime UpdatedAt { get; private set; }

        public string UpdatedById { get; set; }
    }
}
