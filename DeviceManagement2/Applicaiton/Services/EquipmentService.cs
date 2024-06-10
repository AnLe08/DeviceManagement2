using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;

namespace DeviceManagement2.Applicaiton.Services;
public class EquipmentService : IEquipmentService
{
    private readonly IEquipmentRepository _equipmentRepository;
    private readonly IEquipmentService _equipmentService;

    public EquipmentService(IEquipmentRepository equipmentRepository)
    {
        _equipmentRepository = equipmentRepository;
    }

    public async Task AddListAsync(List<Equipment> equipmentList)
    {
        _equipmentRepository.AddList(equipmentList);
        await _equipmentRepository.UnitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(Equipment equipment)
    {
        _equipmentRepository.Update(equipment);
        await _equipmentRepository.UnitOfWork.SaveChangesAsync();
    }

    public async Task CreateEquipmentAsync(CreateEquipmentDto createEquipmentDto)
    {
        var equiment = new Equipment(createEquipmentDto.Name)
        {
            CodeOfManagement = createEquipmentDto.CodeOfManagement,
            SupplierId = createEquipmentDto.SupplierId,
            SpecificationId = createEquipmentDto.SpecificationId
            
        };

        _equipmentRepository.CreateEquipmentAsync(equiment);
        await _equipmentRepository.UnitOfWork.SaveChangesAsync();
    }

    public Task<IEnumerable<Equipment>> GetEquipmentAsync()
    {
        return _equipmentRepository.GetEquipmentAsync();
    }
}
   
