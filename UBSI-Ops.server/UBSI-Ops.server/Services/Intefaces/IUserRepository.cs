using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.UserRoles.Models;
using UBSI_Ops.server.Users.Models;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IUserRepository
    {
        Task<PaginatedList<User>> List(PageOptions options);
        Task<UserRole> GetUserRole(string id);
    }
}
