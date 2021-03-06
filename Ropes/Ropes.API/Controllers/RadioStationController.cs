using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.RadioStations.Models;
using Ropes.API.Services.Intefaces;

namespace Ropes.API.Controllers
{
    [Route("api/radio-stations")]
    [ApiController]
    [Produces("application/json")]
    public class RadioStationController : ControllerBase
    {
        private readonly IRadioStationRepository _radioStationRepository;
        private readonly IMapper _mapper;
        private ILogger<RadioStationController> _logger;

        public RadioStationController(
            IRadioStationRepository radioStationRepository,
            IMapper mapper,
            ILogger<RadioStationController> logger)
        {
            _radioStationRepository = radioStationRepository;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// List all RadioStations
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<RadioStationDto>>> List([FromQuery] PageOptions options)
        {
            var radioStations = await _radioStationRepository.List(options);

            return radioStations.Select(r => _mapper.Map<RadioStationDto>(r));
        }

        /// <summary>
        /// View RadioStation
        /// </summary>
        /// <returns></returns>
        [HttpGet("{stationCode}")]
        public async Task<ActionResult<RadioStationDto>> View(string stationCode)
        {
            _logger.LogInformation("Get Radiostation with code #{id}", stationCode);
            var radioStation = await _radioStationRepository.View(stationCode);
            if (radioStation is null)
            {
                return NotFound();
            }
            else
            {
                return _mapper.Map<RadioStationDto>(radioStation);
            }
        }
    }
}
