using System.Collections.Generic;
using ResoluteWare.InstallationSight.Domain.Structure;

namespace ResoluteWare.InstallationSight.Domain
{
    public class Project: BaseEntity
    {
        public List<Building> Buildings { get; set; }
    }
}
