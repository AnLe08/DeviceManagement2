using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SupplierController : ControllerBase
{
    public readonly ISupplierRepository _supplierRepository;
    public readonly ISupplierService _supplierService;
    public SupplierController(ISupplierRepository supplierRepository, ISupplierService supplierService)
    {
        _supplierRepository = supplierRepository;
        _supplierService = supplierService;
    }
    
    //public SupplierController(ISupplierService supplierService)
    //{
    //    _supplierService = supplierService;
    //}

    [HttpGet]
    public async Task<IEnumerable<Supplier>> GetSuppliersAsync()
    {
        return await _supplierRepository.GetSupplierAsync();
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateSupplierAsync([FromBody] CreateSupplierDto createSupplierDto)
    {
        try
        {
            await _supplierService.CreateSupplierAsync(createSupplierDto);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok();
    
    }

}
    
