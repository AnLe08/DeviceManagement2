using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Models;

namespace DeviceManagement2.Services;


public interface IEquipmentService
{
    Task CreateEquipmentAsync(CreateEquipmentDto createEquipmentDto);
    Task<IEnumerable<Equipment>> GetEquipmentAsync();
    Task AddListAsync(List<Equipment> equipmentList);
    Task UpdateAsync(Equipment equipment);
}

