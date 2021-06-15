
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.RadioStations.Models;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadioStationController : ControllerBase
    {
        private readonly OperationContext _operationContext;
        private readonly IRadioStationRepository _radioStationRepository;
        private readonly IMapper _mapper;
        public RadioStationController(OperationContext operationContext, IRadioStationRepository radioStationRepository, IMapper mapper)
        {
            _operationContext = operationContext;
            _radioStationRepository = radioStationRepository;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<ActionResult<PaginatedList<RadioStation>>> List([FromQuery] PageOptions options)
        {
            var radioStations = await _radioStationRepository.List(options);

            return radioStations.Select(r => r);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<RadioStationDto>> View(string id)
        {
            var radioStations = await _radioStationRepository.View(id);
            if (radioStations is null)
            {
                return NotFound();
            }
            else
            {
                return _mapper.Map<RadioStationDto>(radioStations);
            }
            
        }

    }
}
