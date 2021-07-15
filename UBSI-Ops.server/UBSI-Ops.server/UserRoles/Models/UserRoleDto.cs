using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UBSI_Ops.server.UserRoles.Models
{
    public class UserRoleDto
    {
        public int UserRoleId { get; set; }

        public int RoleId { get; set; }

        public int UserId { get; set; }

        public string Type { get; set; }

        public int BranchId { get; set; }
    }
}
