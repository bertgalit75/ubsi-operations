using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.Roles.Models;

namespace UBSI_Ops.server.Services.Services
{
    public class RoleService
    {
        private readonly OperationContext _operationContext;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public RoleService(OperationContext operationContext, IMapper mapper, ILogger<RoleService> logger)
        {
            _operationContext = operationContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ActionResult<RoleDto>> Create(CreateRoleDto roleDto)
        {
            int lastRoleId = 1;

            if (_operationContext.Roles.Count() > 0)
            {
                lastRoleId = Int32.Parse(_operationContext.Roles.OrderBy(x => x.CreatedAt).LastOrDefault().Id) + 1;
            }
            var role = new Role()
            {
                Id = lastRoleId.ToString(),
                Name = roleDto.Name,
                NormalizedName = roleDto.Name,
            };

            _operationContext.Roles.Add(role);

            await _operationContext.SaveChangesAsync();

            return _mapper.Map<RoleDto>(role);
        }
    }
}
