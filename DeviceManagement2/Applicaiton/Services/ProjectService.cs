using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;

namespace DeviceManagement2.Applicaiton.Services;
public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;
    private readonly IProjectService _projectService; 
    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }
    //public ProjectService(IProjectService projectService)
    //{
    //    _projectService = projectService;
    //}
    public async Task CreateProjectAsync(CreateProjectDto createProjectDto)
    {
        
        var project = new Project(createProjectDto.Content);
        project.Topic = createProjectDto.Topic;
        project.Id = createProjectDto.Id;
        project.StartDate = DateTime.Now;
        project.EndDate = DateTime.Now;

        _projectRepository.CreateProjectAsync(project);
        await _projectRepository.UnitOfWork.SaveChangesAsync();
    }
    public async Task<IEnumerable<Project>> GetProjectAsync()
    {
        return await _projectRepository.GetProjectAsync();
    }

}
    