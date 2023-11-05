using DeviceManagement2.Applicaiton.Dtos;

namespace DeviceManagement2.Services;
public interface ILendingService
{
    Task CreateLendingAsync(CreateLendingDto createLendingDtos);
}
    
    

