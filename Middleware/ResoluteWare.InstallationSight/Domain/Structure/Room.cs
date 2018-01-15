using System.Collections.Generic;

namespace ResoluteWare.InstallationSight.Domain.Structure
{
    public class Room : BaseEntity
    {
        public List<Elevation> Elevations { get; set; }
    }
}