using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;

namespace DeviceManagement2.Applicaiton.Services;
public class LendingService : ILendingService
{
    private readonly ILendingRepository _lendingRepository;
    private readonly ILendingService _lendingService;
    //private readonly IProjectRepository _projectRepository;
    //private readonly IProjectService _projectService;

    public LendingService(ILendingRepository lendingRepository)
    {
        _lendingRepository = lendingRepository;
    }

    public async Task AddListAsync(IEnumerable<Lending> lendings)
    {
        _lendingRepository.AddList(lendings);
        await _lendingRepository.UnitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(Lending lending)
    {
        _lendingRepository.Update(lending);
        await _lendingRepository.UnitOfWork.SaveChangesAsync();
    }

    public async Task CreateLendingAsync(CreateLendingDto createLendingDto)
    {
        var lending = new Lending(createLendingDto.Borrower)
        {
            Reason = createLendingDto.Reason,
            LendingedDate = DateTime.Now,
            Id = createLendingDto.Id,
            Equipment = new List<Equipment>(),
            ProjectId = createLendingDto.ProId,
            Project = createLendingDto.Project
        };
                 

        _lendingRepository.CreateLendingAsync(lending);
        await _lendingRepository.UnitOfWork.SaveChangesAsync();
    }
    

    public Task<IEnumerable<Lending>> GetLendingAsync()
    {
        return _lendingRepository.GetLendingAsync();
    }
}
    
    

