using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateImplementationOrderDto createDto)
        {
            var implementationOrder = _mapper.Map<ImplementationOrder>(createDto);

            await _repository.Add(implementationOrder);

            return BadRequest();
        }
    }
}
