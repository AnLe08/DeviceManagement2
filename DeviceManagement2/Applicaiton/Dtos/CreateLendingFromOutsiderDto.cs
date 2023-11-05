namespace DeviceManagement2.Applicaiton.Dtos;

public class CreateLendingFromOutsiderDto
{
    public string Borrower { get; set; }
    public string Reason { get; set; }
    public string LoanCouponCode { get; set; }
    public string Id = "4aa";


    public CreateLendingFromOutsiderDto(string borrower, string reason, string loanCouponCode)
    {
        Borrower = borrower;
        Reason = reason;
        LoanCouponCode = loanCouponCode;
    }
}


