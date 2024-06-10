using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Models;

namespace DeviceManagement2.Services;
public interface ILendingService
{
    Task CreateLendingAsync(CreateLendingDto createLendingDtos);
    Task<IEnumerable<Lending>> GetLendingAsync();
    Task AddListAsync(IEnumerable<Lending> lendings);
    Task UpdateAsync(Lending lending);
}
    
    

