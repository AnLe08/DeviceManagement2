using DeviceManagement2.Models;

namespace DeviceManagement2.Applicaiton.Dtos;

public class CreateLendingFromOutsiderDto
{
    public string Id { get; set; }
    public string Borrower { get; set; }
    public string Reason { get; set; }
    public string LoanCouponCode { get; set; }
    public string ProTopic { get; set; }
    //public Project proj {  get; set; }
    


    public CreateLendingFromOutsiderDto(string borrower, string reason, string loanCouponCode, string id, string proTopic)
    {
        Borrower = borrower;
        Reason = reason;
        LoanCouponCode = loanCouponCode;
        Id = id;
        ProTopic = proTopic;
    }
}


