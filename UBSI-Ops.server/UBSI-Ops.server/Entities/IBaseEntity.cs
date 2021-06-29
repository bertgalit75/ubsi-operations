using System;

namespace UBSI_Ops.server.Entities
{
    public interface IBaseEntity
    {
        public DateTime CreatedAt { get; }

        public string CreatedById { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedById { get; }
    }
}
