using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.Customers.Models;
using Ropes.API.Services.Intefaces;

namespace Ropes.API.Controllers
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
        [HttpGet("filter/{search}")]
        public async Task<ActionResult<PaginatedList<CustomerDto>>> SearchList([FromQuery] PageOptions options, string search)
        {
            _logger.LogInformation("Get Customers");

            var customers = await _customerRepository.SearchList(options, search);

            return customers.Select(r => _mapper.Map<CustomerDto>(r));
        }

        /// <summary>
        /// Return Specific Customer
        /// </summary>
        /// <returns></returns>
        [HttpGet("{code}")]
        public async Task<ActionResult<CustomerDto>> View(string code)
        {
            _logger.LogInformation("Get Customer #" + code);

            var customer = await _customerRepository.View(code);

            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
