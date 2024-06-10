using DeviceManagement2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Domain.Repositories;

public interface ILendingRepository : IRepository
{
    void AddList(IEnumerable<Lending> lendings);
    void Update(Lending lending);
    void CreateLendingAsync(Lending lending);
    Task<IEnumerable<Lending>> GetLendingAsync();


}
