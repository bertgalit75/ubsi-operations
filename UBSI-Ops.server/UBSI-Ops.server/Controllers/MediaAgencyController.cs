using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.MediaAgencies.Models;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/media-agencies")]
    [ApiController]
    [Produces("application/json")]
    public class MediaAgencyController : Controller
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IMediaAgencyRepository _mediaAgencyRepository;

        public MediaAgencyController(
            ILogger<CustomerController> logger,
            IMapper mapper,
            IMediaAgencyRepository mediaAgencyRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _mediaAgencyRepository = mediaAgencyRepository;
        }

        /// <summary>
        /// List all customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<MediaAgencyDto>>> List([FromQuery] PageOptions options)
        {
            _logger.LogInformation("Get Customers" + options);

            var customers = await _mediaAgencyRepository.List(options);

            return customers.Select(r => _mapper.Map<MediaAgencyDto>(r));
        }


    }
}
