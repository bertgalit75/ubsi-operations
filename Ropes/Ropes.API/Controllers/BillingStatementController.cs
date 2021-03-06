using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ropes.API.Billing.Models;
using Ropes.API.BillingStatements;
using Ropes.API.BillingStatements.Models;
using Ropes.API.Core.Paging;

namespace Ropes.API.Controllers
{
    [Route("api/billing-statements")]
    [ApiController]
    [Produces("application/json")]
    public class BillingStatementController
    {
        private readonly IBillingStatementRepository _repository;
        private readonly IMapper _mapper;

        public BillingStatementController(IBillingStatementRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Generate billing statements
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public Task<ActionResult> Generate([FromBody] NewBillingCycleDto dto)
        {
            throw new System.Exception("TODO");
        }

        /// <summary>
        /// List of Billing Statements
        /// </summary>
        /// <param name="BillingStatementDto"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<BillingStatementDto>>> List([FromQuery] PageOptions options)
        {
            var billingStatements = await _repository.List(options);
            return billingStatements.Select(r => _mapper.Map<BillingStatementDto>(r));
        }

        /// <summary>
        /// Creare Bills from IO
        /// </summary>
        /// <returns></returns>
        [HttpPost("createBills")]
        public List<string> CreateBills([FromBody] List<string> code)
        {
            code.ForEach(x =>
            {
                Console.WriteLine(x);
            });
            return code;
        }
    }
}
