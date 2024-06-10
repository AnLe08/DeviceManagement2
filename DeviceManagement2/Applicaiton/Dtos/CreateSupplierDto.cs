namespace DeviceManagement2.Applicaiton.Dtos;

public class CreateSupplierDto
{
    //private static int _nextId = 1;

    //public int Id { get; private set; }
    public string Name { get; set; }
    public string Addresses { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public CreateSupplierDto(string name, string addresses, string phoneNumber, string email)
    {
        Name = name;
        Addresses = addresses;
        PhoneNumber = phoneNumber;
        Email = email;
        //Id = _nextId++;
        
    }
}

