using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;
using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement2.Infrastructure.Repositories;

public class SpecificationsRepository : BaseRepository, ISpecificationsRepository
{
    public SpecificationsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<IEnumerable<Specifications>> GetAllAsync()
    {
        var specifications = await _context.Specifications.ToListAsync();
        return specifications;
    }
} 