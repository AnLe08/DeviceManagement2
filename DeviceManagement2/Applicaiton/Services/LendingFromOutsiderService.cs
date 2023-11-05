using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;

namespace DeviceManagement2.Applicaiton.Services;

public class LendingFromOutsiderService : ILendingFromOutsiderService
{
    private readonly ILendingFromOutsiderRepository _lendingFromOutsiderRepository;
    public LendingFromOutsiderService(ILendingFromOutsiderRepository lendingFromOutsiderRepository)
    {
        _lendingFromOutsiderRepository = lendingFromOutsiderRepository;
    }
    public async Task CreateLendingFromOutsiderAsync(CreateLendingFromOutsiderDto createLendingFromOutsiderDto)
    {
        var lendingFromOutsider = new LendingFromOutsider(createLendingFromOutsiderDto.LoanCouponCode)
        {
            Reason = createLendingFromOutsiderDto.Reason,
            Borrower = createLendingFromOutsiderDto.Borrower,
            Equipment = new List<Equipment>(),
            LendingedDate = DateTime.Now,
            ReturnedDate = DateTime.Now,
            
        };

        _lendingFromOutsiderRepository.CreateLendingFromOutsiderAsync(lendingFromOutsider);
        await _lendingFromOutsiderRepository.UnitOfWork.SaveChangesAsync();
    }
}


