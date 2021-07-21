using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Roles.Models;
using UBSI_Ops.server.Services.Intefaces;
using UBSI_Ops.server.UserRoles.Models;
using UBSI_Ops.server.Users.Models;

namespace UBSI_Ops.server.Users.Services
{
    public class UserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IRoleRepository _roleRepository;

        public UserService(IMapper mapper,
            IUserRepository userRepository,
            IUserRoleRepository userRoleRepository,
            IRoleRepository roleRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _roleRepository = roleRepository;
        }

        public async Task<PaginatedList<UserDto>> UserList(PageOptions options)
        {
            var users = await _userRepository.List(options);

            var userRoles = await _userRoleRepository.GetUserRolesByUsers(users.Items);

            var roles = await _roleRepository.GetRolesByUserRole(userRoles);

            var userRoleDto = userRoles.Join(roles, ur => ur.RoleId, r => r.Id,
                (ur, r) => new UserRoleDto()
                {
                    BranchId = ur.BranchId,
                    Type = ur.Type,
                    UserId = ur.UserId,
                    UserRoleId = ur.UserRoleId,
                    RoleId = ur.RoleId,
                    Role = _mapper.Map<RoleDto>(r)
                });

            var userDto = users.Items.Join(userRoleDto, u => u.Id, urd => urd.UserId,
                (u, urd) => new UserDto()
                {
                    Email = u.Email,
                    Id = u.Id,
                    Name = u.Name,
                    UserId = u.Id,
                    UserRole = urd
                });

            var total = userDto.Count();

            return new PaginatedList<UserDto>(userDto, total);
        }
    }
}
