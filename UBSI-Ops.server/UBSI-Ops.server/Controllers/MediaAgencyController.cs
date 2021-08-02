using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.MediaAgencies.Models;
using UBSI_Ops.server.MediaAgencies.Services;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/agencies")]
    [ApiController]
    [Produces("application/json")]
    public class MediaAgencyController : Controller
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IMediaAgencyRepository _mediaAgencyRepository;
        private readonly MediaAgencyService _mediaAgencyService;

        public MediaAgencyController(
            ILogger<MediaAgencyController> logger,
            MediaAgencyService mediaAgencyService,
             IMapper mapper,
            IMediaAgencyRepository mediaAgencyRepository)
        {
            _logger = logger;
            _mediaAgencyService = mediaAgencyService;
            _mapper = mapper;
            _mediaAgencyRepository = mediaAgencyRepository;
        }

        /// <summary>
        /// Create new agency
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<MediaAgencyDto>> Create([FromBody] MediaAgencyDto mediaAgencyDto)
        {
            _logger.LogInformation("Add Agency");

            return await _mediaAgencyService.CreateMediaAgency(mediaAgencyDto);
        }

        /// <summary>
        /// List all agencies
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<MediaAgencyDto>>> List([FromQuery] PageOptions options)
        {
            _logger.LogInformation("Get agencies" + options);

            var customers = await _mediaAgencyRepository.List(options);

            return customers.Select(r => _mapper.Map<MediaAgencyDto>(r));
        }

        /// <summary>
        /// Return Specific Agency
        /// </summary>
        /// <returns></returns>
        [HttpGet("{code}")]
        public async Task<ActionResult<MediaAgencyDto>> View(string code)
        {
            _logger.LogInformation("Get Customer #" + code);

            var customer = await _mediaAgencyRepository.View(code);

            return _mapper.Map<MediaAgencyDto>(customer);
        }
    }
}
