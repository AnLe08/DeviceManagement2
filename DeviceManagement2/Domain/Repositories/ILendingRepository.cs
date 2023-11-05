using DeviceManagement2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Domain.Repositories;

public interface ILendingRepository : IRepository
{
    void AddList(IEnumerable<Lending> lendings);
    void Update(Lending lending);
    Task<IEnumerable<Lending>> GetLendingAsync();
    void CreateLendingAsync(Lending lending);
}
