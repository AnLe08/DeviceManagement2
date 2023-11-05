using DeviceManagement2.Applicaiton.Services;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;
using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement2.Infrastructure.Repositories;

public class ProjectRepository : BaseRepository, IProjectRepository
{
    public ProjectRepository(ApplicationDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<IEnumerable<Project>> GetProjectAsync()
    {
        var project = await _context.Projects.ToListAsync(); // đẻ lấy tất cả dữ liệu trong Project thì sử dụng ToList
        return project;
    }

    public void AddList(IEnumerable<Project> project)
    {
        _context.Projects.AddRange(project); //AddRange cho phép thêm vào cả 1 mảng cái model                                  
    }

    public void Update(Project project)
    {
        _context.Projects.Update(project);
    }
    public void CreateProjectAsync(Project project)
    {
        _context.Projects.Add(project);
    }
}