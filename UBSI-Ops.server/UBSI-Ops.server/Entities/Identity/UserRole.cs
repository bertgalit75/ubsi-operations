using System;

namespace UBSI_Ops.server.Entities.Identity
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public int RoleId { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public int BranchId { get; set; }
        public DateTime CreatedAt { get; private set; }
        public string CreatedById { get; set; }
        public DateTime UpdatedAt { get; private set; }
        public string UpdatedById { get; set; }
    }
}
