namespace DeviceManagement2.Models;

public class Supplier
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Addresses { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public List<Equipment> Equipment { get; set; }

    public Supplier(string name, string addresses, string phoneNumber, string email, List<Equipment> equipment, string id)
    {
        Name = name;
        Addresses = addresses;
        PhoneNumber = phoneNumber;
        Email = email;
        Equipment = equipment;
        Id = id;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Supplier() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}

