using System;
using System.Collections.Generic;
using System.Text;

namespace ResoluteWare.InstallationSight.DataAccess.DTO
{
    public class InstallGroupDto: BaseDto
    {
        public string Name { get; set; }

        public string ExternalId { get; set; }

        public int ProjectId { get; set; }
    }
}
