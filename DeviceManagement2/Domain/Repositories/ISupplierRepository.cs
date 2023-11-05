using DeviceManagement2.Models;

namespace DeviceManagement2.Domain.Repositories;

public interface ISupplierRepository
{
    void AddList(IEnumerable<Supplier> suppliers);
    void Update(Supplier supplier);
    Task<IEnumerable<Supplier>> GetSupplierAsync();
}
