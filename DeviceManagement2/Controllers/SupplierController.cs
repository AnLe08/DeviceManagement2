using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SupplierController : ControllerBase
{
    public readonly ISupplierRepository _supplierRepository;
    public SupplierController(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Supplier>> GetSuppliersAsync()
    {
        return await _supplierRepository.GetSupplierAsync();
    }
    
    [HttpPost]
    public async Task<IEnumerable<Supplier>> GetAllAsync()
    {
        return await _supplierRepository.GetSupplierAsync();
    }

}
    
