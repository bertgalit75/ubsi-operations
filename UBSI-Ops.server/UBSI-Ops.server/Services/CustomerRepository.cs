using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class CustomerRepository : Repository, ICustomerRepository
    {
        public CustomerRepository(OperationContext context) : base(context)
        {

        }


        public async Task<PaginatedList<Customer>> List(PageOptions options)
        {
            var query = _context.Customers.
                AsQueryable();

            query = options.Sort switch
            {
                "name" => query.OrderBy(t => t.Name, options.Direction),
                _ => query
            };

            var customers = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<Customer>(customers, total);
        }

        public async Task<PaginatedList<Customer>> SearchList(PageOptions options, string search)
        {
            var query = _context.Customers.
                Where(t => t.Name.Contains(search)).
                AsQueryable();

            query = options.Sort switch
            {
                "name" => query.OrderBy(t => t.Name, options.Direction),
                _ => query
            };

            var customers = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<Customer>(customers, total);
        }
    }
}
