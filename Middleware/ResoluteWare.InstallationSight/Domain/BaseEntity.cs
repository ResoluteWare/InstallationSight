using System;

namespace ResoluteWare.InstallationSight.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ExternalId { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public string ModifiedBy { get; set; }

        public bool IsActive { get; set; }
    }
}