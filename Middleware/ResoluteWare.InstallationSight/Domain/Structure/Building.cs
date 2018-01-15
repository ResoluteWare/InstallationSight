using System.Collections.Generic;

namespace ResoluteWare.InstallationSight.Domain.Structure
{
    public class Building : BaseEntity
    {
        public List<Floor> Floors { get; set; }
    }
}