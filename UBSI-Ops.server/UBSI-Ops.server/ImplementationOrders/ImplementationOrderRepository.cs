using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
﻿using System.Threading.Tasks;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.ImplementationOrders;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class ImplementationOrderRepository : Repository, IImplementationOrderRepository
    {
        public ImplementationOrderRepository(OperationContext context)
            : base(context)
        {
        }

        public async Task Add(ImplementationOrder implementationOrder)
        {
            _context.ImplementationOrders.Add(implementationOrder);
            await _context.SaveChangesAsync();
        }

        public async Task<PaginatedList<ImplementationOrder>> Filter(PageOptions options, int year, int month)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.ImplementationOrders
                           .Include(x => x.Bookings).Include(x => x.MediaAgency).Include(x => x.Customer)
                               .Where(x => x.Bookings.Any(x =>
                                     x.PeriodStart.Month == month &&
                                     x.PeriodStart.Year == year ||
                                     x.PeriodEnd.Month == month &&
                                     x.PeriodEnd.Year == year)).AsQueryable();

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Code, direction),
                "client" => query.OrderBy(t => t.Customer.Name, direction),
                "agency" => query.OrderBy(t => t.MediaAgency.Name, direction),
                "date" => query.OrderBy(t => t.Date, direction),
                "product" => query.OrderBy(t => t.Product, direction),
                _ => query
            };

            var mediaAgencies = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<ImplementationOrder>(mediaAgencies, total);
        }

        public async Task<PaginatedList<ImplementationOrder>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.ImplementationOrders.Include(x => x.Bookings).Include(x => x.MediaAgency).Include(x => x.Customer).AsQueryable();

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Code, direction),
                "client" => query.OrderBy(t => t.Customer.Name, direction),
                "agency" => query.OrderBy(t => t.MediaAgency.Name, direction),
                "date" => query.OrderBy(t => t.Date, direction),
                "product" => query.OrderBy(t => t.Product, direction),
                _ => query
            };

            var mediaAgencies = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<ImplementationOrder>(mediaAgencies, total);
        }
    }
}
