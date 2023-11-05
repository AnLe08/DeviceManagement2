namespace DeviceManagement2.Models;

public class LendingFromOutsider
{
    public string Id { get; set; }
    public DateTime LendingedDate { get; set; }
    public DateTime ReturnedDate { get; set; }
    public string Borrower { get; set; }
    public string Reason { get; set; }
    public string ProjectId { get; set; }
    public Project Project { get; set; }
    public string LoanCouponCode { get; set; }
    public List<Equipment> Equipment { get; set; }

    public LendingFromOutsider(DateTime lendingedDate, string borrower, string reason, Project project, List<Equipment> equipment, DateTime returnedDate, string id, string projectId, string loanCouponCode)
    {
        LendingedDate = lendingedDate;
        Borrower = borrower;
        Reason = reason;
        Project = project;
        Equipment = equipment;
        ReturnedDate = returnedDate;
        Id = id;
        ProjectId = projectId;
        LoanCouponCode = loanCouponCode;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private LendingFromOutsider() { }

    public LendingFromOutsider(string loanCouponCode)
    {
        LoanCouponCode = loanCouponCode;
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}

