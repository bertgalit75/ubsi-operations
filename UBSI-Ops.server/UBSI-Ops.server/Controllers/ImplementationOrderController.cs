using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.ImplementationOrders;
using UBSI_Ops.server.ImplementationOrders.Models;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/implementation-orders")]
    [ApiController]
    [Produces("application/json")]
    public class ImplementationOrderController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IImplementationOrderRepository _repository;

        public ImplementationOrderController(IMapper mapper, IImplementationOrderRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        /// <summary>
        /// Create an implementation order
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ImplementationOrderDto>> Create([FromBody] CreateImplementationOrderDto createDto)
        {
            var implementationOrder = _mapper.Map<ImplementationOrder>(createDto);

            await _repository.Add(implementationOrder);

            var resultDto = _mapper.Map<ImplementationOrderDto>(implementationOrder);

            return resultDto;
        }

        /// <summary>
        /// List of implementation Order filtered by month and year
        /// </summary>
        /// <param name="ImplementationOrderDto"></param>
        /// <returns></returns>
        [HttpGet("{year}/{month}/filter")]
        public async Task<ActionResult<PaginatedList<ImplementationOrderDto>>> FilterByDate([FromQuery] PageOptions pageOptions, int year, int month)
        {
            var implementationOrders = await _repository.Filter(pageOptions, year, month);

            return implementationOrders.Select(r => _mapper.Map<ImplementationOrderDto>(r));
        }

        /// /// <summary>
        /// List All Implementation Order
        /// </summary>
        /// <param name="ImplementationOrderDto"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<ImplementationOrderDto>>> List([FromQuery] PageOptions options)
        {
            var implementationOrders = await _repository.List(options);

            return implementationOrders.Select(r => _mapper.Map<ImplementationOrderDto>(r));
        }
    }
}
