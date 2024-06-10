using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Models;

namespace DeviceManagement2.Services;

public interface ISupplierService
{
    Task CreateSupplierAsync(CreateSupplierDto CreateSupplierDto);
    Task<IEnumerable<Supplier>> GetSuppliersAsync();
    Task AddListAsync(IEnumerable<Supplier> Suppliers);
    Task UpdateAsync(Supplier supplier);
}
