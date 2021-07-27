using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Users.Models;
using UBSI_Ops.server.Users.Services;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/users")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : Controller
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly UserService _userService;

        public UserController(
            ILogger<UserController> logger,
            IMapper mapper,
            UserService userService)
        {
            _logger = logger;
            _mapper = mapper;
            _userService = userService;
        }

        /// <summary>
        /// List all Users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<UserDto>>> List([FromQuery] PageOptions options)
        {
            _logger.LogInformation("Get Users");

            var users = await _userService.UserList(options);

            return users;
        }
    }
}
