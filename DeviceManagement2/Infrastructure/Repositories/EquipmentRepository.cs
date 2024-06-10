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

    public async Task<IEnumerable<Equipment>> GetEquipmentAsync()
    {
        var equipment = await _context.Equipments.ToListAsync();
        return equipment;
    }

    public void AddList(List<Equipment> equipmentList)
    {
        _context.Equipments.AddRange(equipmentList);
    }

    public void Update(Equipment equipment)
    {
        _context.Equipments.Update(equipment);
    }

    public void CreateEquipmentAsync(Equipment equipment)
    {
        _context.Equipments.Add(equipment);
    }
}
