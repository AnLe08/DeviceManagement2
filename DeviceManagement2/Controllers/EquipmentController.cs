using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;
[Route("api/[controller]")]
[ApiController]

public class EquipmentController : ControllerBase
{
    private readonly IEquipmentRepository _equipmentRepository;
    private readonly IEquipmentService  _equipmentService;

    public EquipmentController(IEquipmentRepository equipmentRepository, IEquipmentService equipmentService)
    {
        _equipmentRepository = equipmentRepository;
        _equipmentService = equipmentService;
        
    }
    [HttpGet]
    public async Task<IEnumerable<Equipment>> GetEquipmentAsync()
    {
        return await _equipmentService.GetEquipmentAsync();
    }

    [HttpPost]
    public async Task<IActionResult> CreateEquipmentAsync([FromBody] CreateEquipmentDto createEquipmentDtos)
    {
        try
        {
            await _equipmentService.CreateEquipmentAsync(createEquipmentDtos);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException.Message);
        }
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> PutAsync(Equipment equipment)
    {
        await _equipmentService.UpdateAsync(equipment);
        return Ok();
    }
}
