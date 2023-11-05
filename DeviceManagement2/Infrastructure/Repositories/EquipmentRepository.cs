using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;
using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement2.Infrastructure.Repositories;

public class EquipmentRepository : BaseRepository, IEquipmentRepository
{
    public EquipmentRepository(ApplicationDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<IEnumerable<Equipment>> GetAllAsync()
    {
        var equipment = await _context.Equipments.ToListAsync();
        return equipment;
    }

}
