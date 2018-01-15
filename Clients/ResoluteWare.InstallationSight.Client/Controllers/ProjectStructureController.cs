using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResoluteWare.InstallationSight.Client.Model.Structure;

namespace ResoluteWare.InstallationSight.Client.Controllers
{
    [Route("api/[controller]")]
    public class ProjectStructureController : Controller
    {
        

        [HttpGet("[action]")]
        public Project LoadProject(int projectId)
        {
            return new Project
            {
                Id = 1,
                Name = "Test project",
                Number = "10101"
            };
        }

       
    }
}
