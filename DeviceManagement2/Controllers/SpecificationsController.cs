using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpecificationsController : ControllerBase
{
    public readonly ISpecificationsRepository _specificationsRepository;
    public SpecificationsController(ISpecificationsRepository specificationsRepository)
    {
        _specificationsRepository = specificationsRepository;
    }
    [HttpGet]
    public async Task<IEnumerable<Specifications>> GetAllAsync()
    {
        return await _specificationsRepository.GetAllAsync();
    }
}
  

