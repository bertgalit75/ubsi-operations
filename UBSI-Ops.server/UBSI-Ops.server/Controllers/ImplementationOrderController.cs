using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.ImplementationOrders.Models;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/implementation-orders")]
    [ApiController]
    [Produces("application/json")]


    public class ImplementationOrderController : ControllerBase
    {
        private readonly IImplementationOrderRepository _implementationOrderRepository;
        private readonly IMapper _mapper;
        private ILogger<ImplementationOrderController> _logger;
        public ImplementationOrderController(IImplementationOrderRepository implementationOrderRepository, IMapper mapper, ILogger<ImplementationOrderController> logger)
        {
            _implementationOrderRepository = implementationOrderRepository;
            _mapper = mapper;
            _logger = logger;
        }
        /// <summary>
        /// List all Implementation Order
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<ImplementationOrderDto>>> List([FromQuery] PageOptions options)
        {
            var implementationOrders = await _implementationOrderRepository.List(options);

            return implementationOrders.Select(r => _mapper.Map<ImplementationOrderDto>(r));
        }
    }
}
