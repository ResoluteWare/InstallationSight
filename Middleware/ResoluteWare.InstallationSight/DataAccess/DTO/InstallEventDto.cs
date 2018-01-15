using System;
using System.Collections.Generic;
using System.Text;

namespace ResoluteWare.InstallationSight.DataAccess.DTO
{
    public class InstallEventDto: BaseDto
    {
        public int ComponentId { get; set; }

        public string  Note { get; set; }

        public decimal QtyDone { get; set; }


    }
}
