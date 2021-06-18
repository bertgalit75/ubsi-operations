using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.AccountExecutives.Models;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/account-executive")]
    [ApiController]
    [Produces("application/json")]
    public class AccountExecutiveController : ControllerBase
    {
        private readonly ILogger<AccountExecutiveController> _logger;
        private readonly IMapper _mapper;
        private readonly IAccountExecutiveRepository _accountExecutiveRepository;
        public AccountExecutiveController(IAccountExecutiveRepository accountExecutiveRepository, IMapper mapper, ILogger<AccountExecutiveController> logger)
        {
            _accountExecutiveRepository = accountExecutiveRepository;
            _logger = logger;
            _mapper = mapper;
        }
        /// <summary>
        /// List all Account Executives
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<AccountExecutiveDto>>> List([FromQuery] PageOptions options)
        {
            var accountExecutives = await _accountExecutiveRepository.List(options);

            return accountExecutives.Select(r => _mapper.Map<AccountExecutiveDto>(r));
        }
    }
}
