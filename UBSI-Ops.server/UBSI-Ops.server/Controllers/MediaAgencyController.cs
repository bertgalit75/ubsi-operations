using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.MediaAgencies.Models;
using UBSI_Ops.server.MediaAgencies.Services;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/agencies")]
    [ApiController]
    [Produces("application/json")]
    public class MediaAgencyController : Controller
    {
        private readonly ILogger _logger;
        private readonly MediaAgencyService _mediaAgencyService;

        public MediaAgencyController(
            ILogger<MediaAgencyController> logger,
            MediaAgencyService mediaAgencyService)
        {
            _logger = logger;
            _mediaAgencyService = mediaAgencyService;
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
    }
}
