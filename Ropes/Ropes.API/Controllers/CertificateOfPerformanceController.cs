using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ropes.API.CertificatesofPerformance.Models;
using Ropes.API.CertificatesofPerformance.Services;
using Ropes.API.Core.Paging;
using System.Threading.Tasks;

namespace Ropes.API.Controllers
{
    [Route("api/certificate-of-performance")]
    [ApiController]
    [Produces("application/json")]
    public class CertificateOfPerformanceController : Controller
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly CertificateOfPerformanceService _certificateOfPerformanceService;

        public CertificateOfPerformanceController(
            ILogger<UserController> logger,
            IMapper mapper,
            CertificateOfPerformanceService certificateOfPerformanceService)
        {
            _logger = logger;
            _mapper = mapper;
            _certificateOfPerformanceService = certificateOfPerformanceService;
        }

        /// <summary>
        /// List all CP
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<CertificateOfPerformanceDto>>> List([FromQuery] PageOptions options)
        {
            _logger.LogInformation("Get CPs");

            var cps = await _certificateOfPerformanceService.CPList(options);

            return cps;
        }
    }
}
