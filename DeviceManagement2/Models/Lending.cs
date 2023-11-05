namespace DeviceManagement2.Models;

public class Lending
{
    public string Id { get; set; }
    public DateTime LendingedDate { get; set; }
    public string Borrower { get; set; }
    public string Reason { get; set; }
    public string ProjectId { get; set; }
    public Project Project { get; set; }
    public List<Equipment> Equipment { get; set; }  

    public Lending(DateTime lendingedDate, string borrower, string reason, Project project, List<Equipment> equipment, string id, string projectId)
    {
        LendingedDate = lendingedDate;
        Borrower = borrower;
        Reason = reason;
        Project = project;
        Equipment = equipment;
        Id = id;
        ProjectId = projectId;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Lending() { }

    public Lending(string borrower)
    {
        Borrower = borrower;
    }

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}

