namespace DeviceManagement2.Applicaiton.Dtos;
public class CreateSpecificationsDto
{
    //private static int _nextId = 1;

    //public int Id { get; private set; }
    public string Name { get; set; }
    public string Value { get; set; }

    public CreateSpecificationsDto( string name, string value)
    {
        //Id = _nextId++;
        Name = name;
        Value = value;
    }
}

