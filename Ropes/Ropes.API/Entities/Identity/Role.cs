using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.ObjectModel;

namespace Ropes.API.Entities.Identity
{
    public class Role : IdentityRole<string>, IBaseEntity
    {
        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }

        public Collection<RolePermission> RolePermissions { get; }

        public Role()
        {
            RolePermissions = new Collection<RolePermission>();
        }

        public void AddRolesPermission(RolePermission create)
        {
            var rolePermission = new RolePermission();

            rolePermission.RoleId = Id;

            rolePermission.PermissionCode = create.Code;

            rolePermission.Add = create.Add;

            rolePermission.View = create.View;

            rolePermission.Delete = create.Delete;

            rolePermission.Edit = create.Edit;

            RolePermissions.Add(rolePermission);
        }
    }
}
