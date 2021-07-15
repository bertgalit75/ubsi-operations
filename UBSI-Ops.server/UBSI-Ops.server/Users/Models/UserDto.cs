using UBSI_Ops.server.UserRoles.Models;

namespace UBSI_Ops.server.Users.Models
{
    public class UserDto
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public UserRoleDto UserRoleDto { get; set; }
    }
}
