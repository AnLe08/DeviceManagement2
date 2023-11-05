using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;
using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement2.Infrastructure.Repositories;

public class SupplierRepository : BaseRepository, ISupplierRepository
{
    public SupplierRepository(ApplicationDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<IEnumerable<Supplier>> GetSupplierAsync()
    {
        var supplier = await _context.Suppliers.ToListAsync();
        return supplier;
    }

    public void AddList(IEnumerable<Supplier> supplier)
    {
        _context.Suppliers.AddRange(supplier);
    }

    public void Update(Supplier supplier)
    {
        _context.Suppliers.Update(supplier);
    }
}