using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Models;

namespace DeviceManagement2.Services;

public interface ILendingFromOutsiderService
{
    Task CreateLendingFromOutsiderAsync(CreateLendingFromOutsiderDto createLendingFromOutsiderDtos);
    Task<IEnumerable<LendingFromOutsider>> GetLendingFromOutsiderAsync();
    Task AddListAsync(IEnumerable<LendingFromOutsider> lendingFromOutsiders);
    Task UpdateAsync(LendingFromOutsider lendingFromOutsider);

    //Task<IEnumerable<Project>> GetProjectsAsync();
    //Task <Project> GetProjectAsync(string projectId);

}

