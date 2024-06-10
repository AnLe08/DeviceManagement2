using DeviceManagement2.Models;

namespace DeviceManagement2.Applicaiton.Dtos;
public class CreateLendingDto
{
    public string Borrower { get; set; }
    public string Reason { get; set; }
    public string Id { get; set; }
    public string ProId { get; set; }
    public Project Project { get; }
    public CreateLendingDto(string borrower, string reason, string id, string proId, Project project)
    {
        Borrower = borrower;
        Reason = reason;
        Id = id;
        ProId = proId;
        Project = project;
    }

}

