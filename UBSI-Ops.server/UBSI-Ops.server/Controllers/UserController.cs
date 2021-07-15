using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Services.Intefaces;
using UBSI_Ops.server.UserRoles.Models;
using UBSI_Ops.server.Users.Models;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/users")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : Controller
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserController(
            ILogger<UserController> logger,
            IMapper mapper,
            IUserRepository userRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        /// <summary>
        /// List all customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<UserDto>>> List([FromQuery] PageOptions options)
        {
            _logger.LogInformation("Get Users");

            var users = await _userRepository.List(options);

            var userDto = users.Select(r => _mapper.Map<UserDto>(r));

            var userRole = _userRepository.GetUserRole("0");

            //return userDto;
            return null;
        }


    }
}
