using System;

namespace UBSI_Ops.server.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public DateTime CreatedAt { get; private set; }

        public string CreatedById { get; set; }

        public DateTime UpdatedAt { get; private set;  }

        public string UpdatedById { get; set; }
    }
}
