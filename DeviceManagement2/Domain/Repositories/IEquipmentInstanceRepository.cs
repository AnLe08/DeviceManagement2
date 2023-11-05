using DeviceManagement2.Models;

namespace DeviceManagement2.Domain.Repositories;
public interface IEquipmentInstanceRepository
{
    public Task<IEnumerable<EquipmentInstance>> GetAllAsync();
}
    
    

