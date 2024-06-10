using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;

namespace DeviceManagement2.Applicaiton.Services;

public class SuplierService : ISupplierService
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly ISupplierService _supplierService;
    //private static int _idNext = 1;


    public SuplierService(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }

    public async Task AddListAsync(IEnumerable<Supplier> suppliers)
    {
        _supplierRepository.AddList(suppliers);
        await _supplierRepository.UnitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(Supplier supplier)
    {
        _supplierRepository.Update(supplier);
        await _supplierRepository.UnitOfWork.SaveChangesAsync();
    }

    public async Task CreateSupplierAsync(CreateSupplierDto createSupplierDto)
    {

        var supplier = new Supplier(createSupplierDto.Name/*, createSupplierDto.Id*/)
        {
            Email = createSupplierDto.Email,
            Addresses = createSupplierDto.Addresses,
            PhoneNumber = createSupplierDto.PhoneNumber,
            //Equipment = new List<Equipment>()
        };
        _supplierRepository.CreateSupplierAsync(supplier);
        await _supplierRepository.UnitOfWork.SaveChangesAsync();
    }

   public async Task<IEnumerable<Supplier>> GetSuppliersAsync()
    {
        return await _supplierRepository.GetSupplierAsync();
    }
    

}

