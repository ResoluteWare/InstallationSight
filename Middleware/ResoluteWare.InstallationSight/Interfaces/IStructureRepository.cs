using ResoluteWare.InstallationSight.DataAccess.DTO;

namespace ResoluteWare.InstallationSight.Interfaces
{
    public interface IStructureRepository
    {
        ProjectDto RetrieveProjectStructure(int projectId);
    }
}