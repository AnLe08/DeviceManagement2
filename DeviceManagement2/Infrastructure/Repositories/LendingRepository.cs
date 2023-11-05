using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;
using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement2.Infrastructure.Repositories;

public class LendingRepository : BaseRepository, ILendingRepository
{
    public LendingRepository(ApplicationDbContext dbContext) : base(dbContext) { }

    public async Task<IEnumerable<Lending>> GetLendingAsync()
    {
        var lending = await _context.Lendings.ToListAsync();
        return lending;
    }

    public void AddList(IEnumerable<Lending> lending)
    {
        _context.Lendings.AddRange(lending);
    }

    public void Update(Lending lending)
    {
        _context.Lendings.Update(lending);
    }
    public void CreateLendingAsync(Lending lending)
    {
        _context.Lendings.Add(lending);
    }
}