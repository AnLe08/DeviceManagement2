using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;
[Route("api/[controller]")]
[ApiController]

public class EquipmentController : ControllerBase
{
    private readonly IEquipmentRepository _equipmentRepository;

    public EquipmentController(IEquipmentRepository equipmentRepository)
    {
        _equipmentRepository = equipmentRepository;
    }
    [HttpGet]
    public async Task<IEnumerable<Equipment>> GetAllAsync()
    {
        return await _equipmentRepository.GetAllAsync();
    }
}
