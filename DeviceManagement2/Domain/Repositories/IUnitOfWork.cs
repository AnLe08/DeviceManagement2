namespace DeviceManagement2.Domain.Repositories;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default); // phương thức SaveChanges trả về số dòng bị tác động trong database
}    
    
