using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UBSI_Ops.server.Entities
{
    public class UserOrganization : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }
    }
}
