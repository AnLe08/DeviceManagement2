using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;
using DeviceManagement2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

namespace DeviceManagement2.Infrastructure.Repositories;

public class LendingFromOutsiderRepository : BaseRepository, ILendingFromOutsiderRepository
{
    public LendingFromOutsiderRepository(ApplicationDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<IEnumerable<LendingFromOutsider>> GetLendingFromOutsiderAsync()
    {
        var le = await _context.LendingFromOutsiders.ToListAsync();
        return le;
    }
    public async Task<IEnumerable<Project>> GetProjectsAsync()
    {
        var proData = await _context.LendingFromOutsiders.ToListAsync();
        return (IEnumerable<Project>)proData;
    }

    public void AddList(IEnumerable<LendingFromOutsider> lendingFromOutsiders)
    {
        _context.LendingFromOutsiders.AddRange(lendingFromOutsiders);
    }

    public void Update(LendingFromOutsider lendingFromOutsider)
    {
        _context.LendingFromOutsiders.Update(lendingFromOutsider);
    }
    public void CreateLendingFromOutsiderAsync(LendingFromOutsider lendingFromOutsider)
    {
        _context.LendingFromOutsiders.Add(lendingFromOutsider);
    }                                                                        
    public async Task<Project> GetProjectAsync(string projectId)
    {
        var pro =  _context.LendingFromOutsiders
            .Select(p => p.ProjectId == projectId) ;
        return new Project();
          
    }
}
