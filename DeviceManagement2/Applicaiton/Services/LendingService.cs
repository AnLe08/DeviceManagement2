using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;

namespace DeviceManagement2.Applicaiton.Services;
public class LendingService : ILendingService
{
    private readonly ILendingRepository _lendingRepository;
    private readonly IProjectRepository _projectRepository;
    private readonly IProjectService _projectService;
    private readonly ProjectService project;

    public LendingService(ILendingRepository lendingRepository)
    {
        _lendingRepository = lendingRepository;
    }
    //public ProjectService()

    public async Task CreateLendingAsync(CreateLendingDto createLendingDto)
    {
        var lending = new Lending(createLendingDto.Borrower)
        {
            Reason = createLendingDto.Reason,
            LendingedDate = DateTime.Now,
            Id = createLendingDto.Id,
            Equipment = new List<Equipment>(),
            
        };
                 
  

        _lendingRepository.CreateLendingAsync(lending);
        await _lendingRepository.UnitOfWork.SaveChangesAsync();

    } 
}
    
    

