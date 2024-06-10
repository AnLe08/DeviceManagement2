using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Applicaiton.Services;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LendingFromOutsiderController : ControllerBase
{
    public readonly ILendingFromOutsiderRepository _lendingFromOutsiderRepository;
    public readonly ILendingFromOutsiderService _lendingFromOutsiderService;
    //    public LendingFromOutSiderController(ILendingFromOutsiderRepository lendingFromOutsiderRepository)
    //    {
    //        _lendingFromOutsiderRepository = lendingFromOutsiderRepository;
    //    }
    //khai báo cho ILendingFromOutsiderRepository nhưng gỡ cmt thì sẽ gặp lỗi yêu cầu nhiều service cùng 1 lúc
    public LendingFromOutsiderController(ILendingFromOutsiderService lendingFromOutsiderService)
    {
        _lendingFromOutsiderService = lendingFromOutsiderService;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateLendingFromOutsiderAsync([FromBody] CreateLendingFromOutsiderDto createLendingFromOutsiderDtos)
    {
        try
        {
            await _lendingFromOutsiderService.CreateLendingFromOutsiderAsync(createLendingFromOutsiderDtos);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok();

    }

    [HttpGet]
    public async Task<IEnumerable<LendingFromOutsider>> GetLendingFromOutsidersAsync()
    {
        return await _lendingFromOutsiderService.GetLendingFromOutsiderAsync(); // đã khai báo ở hàng 17 => ko null
    }
}
   
   

