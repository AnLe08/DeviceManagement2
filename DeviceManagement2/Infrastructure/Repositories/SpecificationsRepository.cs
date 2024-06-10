using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;
using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace DeviceManagement2.Infrastructure.Repositories;

public class SpecificationsRepository : BaseRepository, ISpecificationsRepository
{
    public SpecificationsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<IEnumerable<Specifications>> GetSpecificationsAsync()
    {
        var specifications = await _context.Specifications.ToListAsync();
        return specifications;
    }
    public void CreateSpecificationsAsync(Specifications specifications)
    {
        _context.Specifications.Add(specifications);
    }
} 