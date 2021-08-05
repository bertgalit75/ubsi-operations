using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UBSI_Ops.server.Billing.Models;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/billing-statements")]
    [ApiController]
    [Produces("application/json")]
    public class BillingStatementController
    {
        public BillingStatementController()
        {
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
