using System;
using System.Collections.Generic;
using System.Text;
using ResoluteWare.InstallationSight.DataAccess.DTO;
using ResoluteWare.InstallationSight.Interfaces;

namespace ResoluteWare.InstallationSight.DataAccess.Repository
{
    public class InstallRepository: IInstallRepository
    {
        public List<ComponentDto> GetComponentDtos(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<ComponentDto> GetComponentDtosByGroupId(int installGrpId)
        {
            throw new NotImplementedException();
        }
    }
}
