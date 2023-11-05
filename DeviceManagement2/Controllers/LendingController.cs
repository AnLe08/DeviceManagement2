using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LendingController : ControllerBase
{
    public readonly ILendingRepository _lendingRepository;
    public readonly ILendingService _lendingService;

    /*
    public LendingController(ILendingRepository lendingRepository)
    {
        _lendingRepository = lendingRepository;
    }
    */
    public LendingController(ILendingService lendingService)
    {
        _lendingService = lendingService;
    }

    [HttpGet]
    public async Task<IEnumerable<Lending>> GetLendingAsync()
    {
        return await _lendingRepository.GetLendingAsync();
    }

    [HttpPost]
    public async Task<IActionResult> CreateLendingAsync([FromBody] CreateLendingDto createLendingDtos)
    {
        try
        {
            await _lendingService.CreateLendingAsync(createLendingDtos);
        } 
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException.Message);
        }
        return Ok();
        
    }    
}
/* rest endpoint convention
     quy luật sử dụng các method     
     những chổ nào nên sử dụng danh từ và động từ
     xây Dto để lấy những thông tin cần thiết
*/
