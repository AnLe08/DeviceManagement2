using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Controllers;
using DeviceManagement2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagement2.Domain.Repositories;

public interface ILendingFromOutsiderRepository : IRepository
{
    void AddList(IEnumerable<LendingFromOutsider> lendingFromOutsiders);
    void Update(LendingFromOutsider lendingFromOutsider);
    void CreateLendingFromOutsiderAsync(LendingFromOutsider lendingFromOutsider);
    Task<Project> GetProjectAsync(string projectId);
    Task<IEnumerable<Project>> GetProjectsAsync();
    Task<IEnumerable<LendingFromOutsider>> GetLendingFromOutsiderAsync();

}
