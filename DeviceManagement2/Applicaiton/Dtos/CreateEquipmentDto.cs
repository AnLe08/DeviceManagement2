
namespace DeviceManagement2.Applicaiton.Dtos;

public class CreateEquipmentDto
{
    public string Name { get; set; }
    public string CodeOfManagement { get; set; }
    public int SupplierId { get; set; }
    public int SpecificationId { get; set; }
    public int LendingFromOutsiderId { get; }

    public CreateEquipmentDto(string name, string codeOfManagement, int supplierId, int specificationId, int lendingFromOutsiderId)
    {
        Name = name;
        CodeOfManagement = codeOfManagement;
        SupplierId = supplierId;
        SpecificationId = specificationId;
        LendingFromOutsiderId = lendingFromOutsiderId;
    }
}

