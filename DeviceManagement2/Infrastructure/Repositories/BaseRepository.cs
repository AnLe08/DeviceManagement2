using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;

namespace DeviceManagement2.Infrastructure.Repositories;


public class BaseRepository : IRepository
{
    protected ApplicationDbContext _context { get; set; }
    public IUnitOfWork UnitOfWork => _context;
    public BaseRepository(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

}