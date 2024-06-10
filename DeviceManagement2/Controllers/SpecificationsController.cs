using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpecificationsController : ControllerBase
{
    public readonly ISpecificationsRepository _specificationsRepository;
    public readonly ISpecificationsService _specificationsService;
    public SpecificationsController(ISpecificationsRepository specificationsRepository, ISpecificationsService specificationsService)
    {
        _specificationsRepository = specificationsRepository;
        _specificationsService = specificationsService;
    }
    [HttpGet]

    public async Task<IEnumerable<Specifications>> GetSpecificationsAsync()
    {
        return await _specificationsRepository.GetSpecificationsAsync();
    }

    [HttpPost]
    public async Task<IActionResult> CreateSpecificationsAsync([FromBody] CreateSpecificationsDto createSpecificationsDtos)
    {
        try
        {
            await _specificationsService.CreateSpecificationsAsync(createSpecificationsDtos);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok();
    }
}
  

