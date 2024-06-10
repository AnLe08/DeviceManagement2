using DeviceManagement2.Models;

namespace DeviceManagement2.Domain.Repositories;

public interface IEquipmentRepository : IRepository
{
    void AddList(List<Equipment> equipmentList);
    void Update(Equipment equipment);
    void CreateEquipmentAsync(Equipment equipment); 
    Task<IEnumerable<Equipment>> GetEquipmentAsync();
}
