using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Entities
{
    public class RolePermission
    {
        public int Code { get; set; }

        public string RoleId { get; set; }

        public int PermissionCode { get; set; }

        public bool View { get; set; }

        public bool Add { get; set; }

        public bool Edit { get; set; }

        public bool Delete { get; set; }

        public Role Role { get; set; }

        public Permission Permission { get; set; }
    }
}
