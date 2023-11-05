using DeviceManagement2.Models;

namespace DeviceManagement2.Domain.Repositories;

public interface IEquipmentRepository
{
    public Task<IEnumerable<Equipment>> GetAllAsync();
}
