namespace UBSI_Ops.server.Permissions.Models
{
    public class PermissionDto
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public bool View { get; set; }

        public bool Add { get; set; }

        public bool Edit { get; set; }

        public bool Delete { get; set; }
    }
}
