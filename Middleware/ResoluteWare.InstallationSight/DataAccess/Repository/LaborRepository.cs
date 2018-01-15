using System;
using System.Collections.Generic;
using ResoluteWare.InstallationSight.Domain.Manpower;
using ResoluteWare.InstallationSight.Interfaces;

namespace ResoluteWare.InstallationSight.DataAccess.Repository
{
    public class LaborRepository : ILaborRepository
    {
        public List<LaborHour> RetriveLaborByInstallProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<LaborHour> RetriveLaborByInstallGroup(int installGrpId)
        {
            throw new NotImplementedException();
        }
    }
}