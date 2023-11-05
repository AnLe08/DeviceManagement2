namespace DeviceManagement2.Models;

public class Project
{
    public string? Id { get; set; }
    public string? Topic { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Content { get; set; }

    public Project(string topic, DateTime startDate, DateTime endDate, string content, string id)
    {
        Topic = topic;
        StartDate = startDate;
        EndDate = endDate;
        Content = content;
        Id = id;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Project() { }


    public Project(string content)
    {
        Content = content;        
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


}

