namespace DeviceManagement2.Models;

public class Supplier
{

    public int Id { get; private set; }
    public string Name { get; set; }
    public string Addresses { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Equipment EquipmentId { get; set; }

    public Supplier(string name, string addresses, string phoneNumber, string email, Equipment equipmentId, int id)
    {
        Name = name;
        Addresses = addresses;
        PhoneNumber = phoneNumber;
        Email = email;
        Id = id;
        EquipmentId = equipmentId;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Supplier() { }

    public Supplier(string name/*, int id*/)
    {
        Name = name;
        //Id = id;
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}

