using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;
using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement2.Infrastructure.Repositories;
public class EquipmentInstanceRepository : BaseRepository, IEquipmentInstanceRepository
{
    public EquipmentInstanceRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<EquipmentInstance>> GetAllAsync()
    {
        var equipmentInstance = await _context.EquipmentInstances.ToListAsync();
        return equipmentInstance;
    }
}
    

