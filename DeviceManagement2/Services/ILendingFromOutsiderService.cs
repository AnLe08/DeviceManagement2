using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Models;

namespace DeviceManagement2.Services;

public interface ILendingFromOutsiderService
{
    Task CreateLendingFromOutsiderAsync(CreateLendingFromOutsiderDto createLendingFromOutsiderDtos);
}

