using System.Collections.Generic;

namespace Ropes.API.Roles.Models
{
    public class CreateRoleDto
    {
        public string Name { get; set; }

        public ICollection<RolePermissionDto> RolePermissions { get; set; }

        public class RolePermissionDto
        {
            public int Code { get; set; }

            public bool View { get; set; }

            public bool Add { get; set; }

            public bool Edit { get; set; }

            public bool Delete { get; set; }
        }
    }
}
