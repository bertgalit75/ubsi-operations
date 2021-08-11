using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.CertificatesofPerformance.Models;
using UBSI_Ops.server.CertificatesofPerformance.Services;
using UBSI_Ops.server.Core.Paging;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/certificate-of-performance")]
    [ApiController]
    [Produces("application/json")]
    public class CertificateOfPerformanceController : Controller
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly CertificateOfPerformanceService _certificateOfPerformanceService;
        public CertificateOfPerformanceController(ILogger<UserController> logger,
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
