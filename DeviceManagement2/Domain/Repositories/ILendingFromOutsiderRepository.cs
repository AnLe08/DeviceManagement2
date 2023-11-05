using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Controllers;
using DeviceManagement2.Models;

namespace DeviceManagement2.Domain.Repositories;

public interface ILendingFromOutsiderRepository : IRepository
{
    void AddList(IEnumerable<LendingFromOutsider> lendingFromOutsiders);
    void Update(LendingFromOutsider lendingFromOutsider);
    Task<IEnumerable<LendingFromOutsider>> GetLendingFromOutsiderAsync();
    void CreateLendingFromOutsiderAsync(LendingFromOutsider lendingFromOutsider);
}
