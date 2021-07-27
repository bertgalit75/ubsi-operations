using Microsoft.AspNetCore.Identity;
using System;

namespace UBSI_Ops.server.Entities.Identity
{
    public class Role : IdentityRole<string>, IBaseEntity
    {
        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }
    }
}
