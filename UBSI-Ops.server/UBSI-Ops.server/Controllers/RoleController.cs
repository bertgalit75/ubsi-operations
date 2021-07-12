using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Roles.Models;
using UBSI_Ops.server.Services.Intefaces;
using UBSI_Ops.server.Services.Services;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/roles")]
    [ApiController]
    [Produces("application/json")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly RoleService _roleService;

        public RoleController(
            IRoleRepository roleRepository,
            IMapper mapper,
            RoleService roleService,
            ILogger<RoleController> logger)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// List all Roles
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<RoleDto>>> List([FromQuery] PageOptions options)
        {
            _logger.LogInformation("Get Roles");

            var customers = await _roleRepository.List(options);

            return customers.Select(r => _mapper.Map<RoleDto>(r));
        }

        /// <summary>
        /// Insert New Role
        /// </summary>
        /// <returns></returns>
        [HttpPost("new")]
        public async Task<ActionResult<RoleDto>> CreateRole([FromBody] CreateRoleDto model)
        {
            return await _roleService.Create(model);
        }
    }
}
