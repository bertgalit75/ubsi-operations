using System;

namespace Ropes.API.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public DateTime CreatedAt { get; private set; }

        public string CreatedByCode { get; set; }

        public DateTime UpdatedAt { get; private set; }

        public string UpdatedByCode { get; set; }
    }
}
