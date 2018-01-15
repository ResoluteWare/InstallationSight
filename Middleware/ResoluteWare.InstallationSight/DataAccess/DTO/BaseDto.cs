using System;

namespace ResoluteWare.InstallationSight.DataAccess.DTO
{
    public abstract class BaseDto
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public string ModifiedBy { get; set; }

        public bool IsActive { get; set; }
    }
}