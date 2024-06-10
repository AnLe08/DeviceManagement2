using DeviceManagement2.Models;

namespace DeviceManagement2.Domain.Repositories;

public interface ISpecificationsRepository :IRepository
{
    Task<IEnumerable<Specifications>> GetSpecificationsAsync();
    void CreateSpecificationsAsync (Specifications specifications);
}
