using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Applicaiton.Services;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProjectController : ControllerBase
{
    public readonly IProjectService _projectService;

    public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
        
    }

    [HttpPost]
    public async Task<IActionResult> CreateProjectAsync([FromBody] CreateProjectDto createProjectDtos)
    {
        try
        {
            await _projectService.CreateProjectAsync(createProjectDtos);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok();
    }

    [HttpGet]
    public async Task<IEnumerable<Project>> GetAllAsync()
    {
        return await _projectService.GetProjectAsync();
    }
}
    

