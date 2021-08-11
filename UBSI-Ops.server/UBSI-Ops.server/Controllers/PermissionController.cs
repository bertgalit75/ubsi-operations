using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Permissions;
using UBSI_Ops.server.Permissions.Models;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/permissions")]
    [ApiController]
    [Produces("application/json")]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public PermissionController(IPermissionRepository permissionRepository, ILogger<PermissionController> logger, IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// List all Permissions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<PermissionDto>>> List([FromQuery] PageOptions options)
        {
            _logger.LogInformation("Get permissions");

            var permissions = await _permissionRepository.List(options);

            return permissions.Select(r => _mapper.Map<PermissionDto>(r));
        }
    }
}
