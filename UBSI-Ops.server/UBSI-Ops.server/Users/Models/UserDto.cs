using Ropes.API.UserRoles.Models;

namespace Ropes.API.Users.Models
{
    public class UserDto
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public UserRoleDto UserRole { get; set; }
    }
}
