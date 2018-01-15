using System.Collections.Generic;

namespace ResoluteWare.InstallationSight.Domain.Structure
{
    public class Floor : BaseEntity
    {
        public List<Room> Rooms { get; set; }
    }
}