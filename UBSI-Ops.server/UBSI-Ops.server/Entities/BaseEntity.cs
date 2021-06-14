using System;

namespace UBSI_Ops.server.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public DateTime CreatedAt { get; private set; }

        public int CreatedById { get; set; }

        public DateTime UpdatedAt { get; private set;  }

        public int UpdatedById { get; set; }
    }
}
