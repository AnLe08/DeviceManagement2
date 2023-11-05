namespace DeviceManagement2.Applicaiton.Dtos;
public class CreateProjectDto
{
    public string Content { get; set; }
    public string? Topic { get; set; }
    public string Id { get; set; }

    public CreateProjectDto(string content, string topic, string id)
    {
        Content = content;
        Topic = topic;
        Id = id;
    }
}


