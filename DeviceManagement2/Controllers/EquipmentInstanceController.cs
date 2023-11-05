using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;
[Route("api/[controller]")]
[ApiController]

public class EquipmentInstanceController : ControllerBase
{
    private readonly IEquipmentInstanceRepository _equipmentInstanceRepository;
    public EquipmentInstanceController(IEquipmentInstanceRepository equipmentInstanceRepository)
    {
        _equipmentInstanceRepository = equipmentInstanceRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<EquipmentInstance>> GatAllAsync()
    {
        return await _equipmentInstanceRepository.GetAllAsync();
    }
}
    
    

