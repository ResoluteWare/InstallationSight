using System.Collections.Generic;
using ResoluteWare.InstallationSight.DataAccess.DTO;

namespace ResoluteWare.InstallationSight.Interfaces
{
    public interface IInstallRepository
    {
        List<ComponentDto> GetComponentDtos(int projectId);

        List<ComponentDto> GetComponentDtosByGroupId(int installGrpId);

        void PersistInstallEvent(List<InstallEventDto> installEventDtos);
    }
}