using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Models;

namespace DeviceManagement2.Services;
public interface ISpecificationsService
{
    Task<IEnumerable<Specifications>> GetSpecificationsAsync();
    Task CreateSpecificationsAsync(CreateSpecificationsDto specificationsDto);
}

