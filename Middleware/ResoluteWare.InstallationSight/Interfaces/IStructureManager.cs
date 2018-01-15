using ResoluteWare.InstallationSight.Domain;

namespace ResoluteWare.InstallationSight.Interfaces
{
    public interface IStructureManager
    {
        Project GetProjectStructure(string projectId);
    }
}