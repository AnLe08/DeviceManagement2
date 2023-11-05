using DeviceManagement2.Applicaiton.Services;
using DeviceManagement2.Models;

namespace DeviceManagement2.Domain.Repositories;

public interface IProjectRepository : IRepository
{
    void AddList(IEnumerable<Project> projects);
    void Update(Project project);
    Task<IEnumerable<Project>> GetProjectAsync();
    void CreateProjectAsync(Project project);
}