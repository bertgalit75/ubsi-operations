using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadioStationController : ControllerBase
    {
        private readonly OperationContext _operationContext;
        private readonly IRadioStationRepository _radioStationRepository;
        public RadioStationController(OperationContext operationContext, IRadioStationRepository radioStationRepository)
        {
            _operationContext = operationContext;
            _radioStationRepository = radioStationRepository;
        }
        [HttpGet]
        public async Task<ActionResult<PaginatedList<RadioStation>>> List([FromQuery] PageOptions options)
        {
            var radioStations = await _radioStationRepository.List(options);

            return radioStations.Select(r => r);
        }


    }
}
