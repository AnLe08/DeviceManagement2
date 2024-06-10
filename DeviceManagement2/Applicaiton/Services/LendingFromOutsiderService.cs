using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace DeviceManagement2.Applicaiton.Services;

public class LendingFromOutsiderService : ILendingFromOutsiderService
{
    private readonly ILendingFromOutsiderRepository _lendingFromOutsiderRepository;
    private readonly ILendingFromOutsiderService _lendingFromOutsiderService;
    //private readonly IProjectService _projectService;

    //public LendingFromOutsiderService(ILendingFromOutsiderRepository lendingFromOutsiderRepository, ILendingFromOutsiderService lendingFromOutsiderService)
    //{
    //    _lendingFromOutsiderRepository = lendingFromOutsiderRepository;
    //    _lendingFromOutsiderService = lendingFromOutsiderService;
    //}

    public LendingFromOutsiderService(ILendingFromOutsiderRepository lendingFromOutsiderRepository)
    {
        _lendingFromOutsiderRepository = lendingFromOutsiderRepository;
    }

    public async Task AddListAsync(IEnumerable<LendingFromOutsider> lendingFromOutsiders)
    {
        _lendingFromOutsiderRepository.AddList(lendingFromOutsiders);
        await _lendingFromOutsiderRepository.UnitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(LendingFromOutsider lendingFromOutsider)
    {
        _lendingFromOutsiderRepository.Update(lendingFromOutsider);
        await _lendingFromOutsiderRepository.UnitOfWork.SaveChangesAsync();
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
            Project = new Project() { Id = createLendingFromOutsiderDto.ProTopic , Topic = "", Content = "", EndDate = DateTime.Today, StartDate = DateTime.Today },
            ProjectId = createLendingFromOutsiderDto.ProTopic,
            Id = createLendingFromOutsiderDto.Id
        };


        _lendingFromOutsiderRepository.CreateLendingFromOutsiderAsync(lendingFromOutsider);
        await _lendingFromOutsiderRepository.UnitOfWork.SaveChangesAsync();
    }
   

    public Task<IEnumerable<LendingFromOutsider>> GetLendingFromOutsiderAsync()
    {
        return _lendingFromOutsiderRepository.GetLendingFromOutsiderAsync();
    }

    //public async Task GetLendingFromOutsiderByProjectIdAsync(string projectId)
    //{
    //    var allLendings = await _lendingFromOutsiderRepository.GetLendingFromOutsiderAsync();

    //    var lendingFromProject = allLendings.Where(lending => lending.ProjectId == projectId).ToList();

    //}

    //public async Task<Project> GetProjectAsync(string projectId)
    //{
    //    return await _lendingFromOutsiderRepository.GetProjectAsync(projectId);

    //}
}


