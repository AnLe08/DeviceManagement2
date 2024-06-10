using DeviceManagement2.Applicaiton.Dtos;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;

namespace DeviceManagement2.Applicaiton.Services;
public class SpecificationsService : ISpecificationsService
{
    private readonly ISpecificationsRepository _specificationsRepository;
    private readonly ISpecificationsService _specificationsService;

    public SpecificationsService(ISpecificationsRepository specificationsRepository)
    {
        _specificationsRepository = specificationsRepository;
    }

    public async Task CreateSpecificationsAsync(CreateSpecificationsDto createSpecificationsDto)
    {
        var specifications = new Specifications(createSpecificationsDto.Name /*,createSpecificationsDto.Id*/)
        {
            Value = createSpecificationsDto.Value
        };
        _specificationsRepository.CreateSpecificationsAsync(specifications);
        await _specificationsRepository.UnitOfWork.SaveChangesAsync();
    }

    public async Task<IEnumerable<Specifications>> GetSpecificationsAsync()
    {
        return await _specificationsRepository.GetSpecificationsAsync();
    }
}
    

