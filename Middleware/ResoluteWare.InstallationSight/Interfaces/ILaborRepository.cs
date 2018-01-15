using System.Collections.Generic;
using ResoluteWare.InstallationSight.Domain.Manpower;

namespace ResoluteWare.InstallationSight.Interfaces
{
    public interface ILaborRepository
    {
        List<LaborHour> RetriveLaborByInstallProject(int projectId);

        List<LaborHour> RetriveLaborByInstallGroup(int InstallGrpId);
    }
}