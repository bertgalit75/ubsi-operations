using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Customers.Models;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/customers")]
    [ApiController]
    [Produces("application/json")]
    public class CustomerController : Controller
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(
            ILogger<CustomerController> logger,
            IMapper mapper,
            ICustomerRepository customerRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        /// <summary>
        /// List all customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<CustomerDto>>> List([FromQuery] PageOptions options)
        {
            _logger.LogInformation("Get Customers");

            var customers = await _customerRepository.List(options);

            return customers.Select(r => _mapper.Map<CustomerDto>(r));
        }

        /// <summary>
        /// List all customers that matches the search
        /// </summary>
        /// <returns></returns>
        [HttpGet("{search}")]
        public async Task<ActionResult<PaginatedList<CustomerDto>>> SearchList([FromQuery] PageOptions options, string search)
        {
            _logger.LogInformation("Get Customers");

            var customers = await _customerRepository.SearchList(options, search);

            return customers.Select(r => _mapper.Map<CustomerDto>(r));
        }
    }
}