using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Models;

namespace DeviceManagement2.Services;
public interface IProjectService
{
    Task CreateProjectAsync(CreateProjectDto createProjectDtos);
    Task<IEnumerable<Project>> GetProjectAsync();
    Task AddListAsync(IEnumerable<Project> projects);
    Task UpdateAsync(Project project);
}

