using UBSI_Ops.server.Roles.Models;

namespace UBSI_Ops.server.UserRoles.Models
{
    public class UserRoleDto
    {
        public int UserRoleId { get; set; }

        public string RoleId { get; set; }

        public string UserId { get; set; }

        public string Type { get; set; }

        public int BranchId { get; set; }

        public RoleDto Role { get; set; }
    }
}
