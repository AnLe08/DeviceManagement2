namespace DeviceManagement2.Models;

public class Specifications
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }

    public Specifications(string name, string value, string id)
    {
        Name = name;
        Value = value;
        Id = id;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Specifications() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
