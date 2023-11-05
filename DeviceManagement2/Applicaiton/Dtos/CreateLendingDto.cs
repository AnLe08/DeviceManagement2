using DeviceManagement2.Models;

namespace DeviceManagement2.Applicaiton.Dtos;
public class CreateLendingDto
{
    public string Borrower { get; set; }
    public string Reason { get; set; }
    
    public string Id = "12z";
    public CreateLendingDto(string borrower, string reason)
    {
        Borrower = borrower;
        Reason = reason;
    }

}

