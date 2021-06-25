using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Services.Intefaces;
using UBSI_Ops.server.Vendors.Models;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/vendor")]
    [ApiController]
    [Produces("application/json")]
    public class VendorController : ControllerBase
    {
        private readonly ILogger<VendorController> _logger;
        private readonly IMapper _mapper;
        private readonly IVendorRepository _vendorRepository;
        public VendorController(ILogger<VendorController> logger, IMapper mapper, IVendorRepository vendorRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _vendorRepository = vendorRepository;
        }
        /// <summary>
        /// List all Vendors
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<VendorDto>>> List([FromQuery] PageOptions options)
        {
            var vendors = await _vendorRepository.List(options);

            return vendors.Select(r => _mapper.Map<VendorDto>(r));
        }
        /// <summary>
        /// View Vendor
        /// </summary>
        /// <returns></returns>
        [HttpGet("{vendorCode}")]
        public async Task<ActionResult<VendorDto>> View(string vendorCode)
        {
            _logger.LogInformation("Get Vendor with code #{id}", vendorCode);
            var vendor = await _vendorRepository.View(vendorCode);
            if (vendor is null)
            {
                return NotFound();
            }
            else
            {
                return _mapper.Map<VendorDto>(vendor);
            }
        }
    }
}
