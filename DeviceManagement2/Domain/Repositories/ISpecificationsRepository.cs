using DeviceManagement2.Models;

namespace DeviceManagement2.Domain.Repositories;

public interface ISpecificationsRepository
{
    Task<IEnumerable<Specifications>> GetAllAsync();
}
