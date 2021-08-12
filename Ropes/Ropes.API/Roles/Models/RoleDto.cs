using System.Collections.ObjectModel;

namespace Ropes.API.Roles.Models
{
    public class RoleDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Collection<RolePermissionDto> RolePermissions { get; set; }

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
