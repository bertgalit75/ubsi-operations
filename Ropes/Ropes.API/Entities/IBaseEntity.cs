using System;

namespace Ropes.API.Entities
{
    public interface IBaseEntity
    {
        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }
    }
}
