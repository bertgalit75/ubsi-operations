using System;

namespace UBSI_Ops.server.Entities
{
    public interface IBaseEntity
    {
        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }
    }
}
