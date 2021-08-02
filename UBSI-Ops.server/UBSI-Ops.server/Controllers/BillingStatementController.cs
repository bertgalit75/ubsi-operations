using Microsoft.AspNetCore.Mvc;
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
    }
}
