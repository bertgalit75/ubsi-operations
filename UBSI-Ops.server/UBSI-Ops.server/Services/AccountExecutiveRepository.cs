using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Ropes.API.Core.Extensions;
using Ropes.API.Core.Paging;
using Ropes.API.Data;
using Ropes.API.Entities;
using Ropes.API.Services.Intefaces;

namespace Ropes.API.Services
{
    public class AccountExecutiveRepository : Repository, IAccountExecutiveRepository
    {
        public AccountExecutiveRepository(OperationContext context) : base(context)
        {
        }

        public async Task<PaginatedList<AccountExecutive>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.AccountExecutives.AsQueryable();

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Code, direction),
                "fullName" => query.OrderBy(t => t.FirstName + " " + t.MiddleInitial + ", " + t.LastName, direction),
                "areaCode" => query.OrderBy(t => t.AreaCode, direction),
                _ => query
            };

            var accountExecutives = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<AccountExecutive>(accountExecutives, total);
        }

        public async Task<AccountExecutive> View(string code)
        {
            return await _context.AccountExecutives.Where(x => x.Code == code).FirstOrDefaultAsync();
        }
    }
}
