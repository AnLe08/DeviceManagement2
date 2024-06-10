namespace DeviceManagement2.Models;

public class Equipment
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Picture { get; set; }
    public string CodeOfManagement { get; set; }
    public Status Status { get; set; }
    public Type Type { get; set; }
    public DateTime YearSupply { get; set; }
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; }
    public int SpecificationId { get; set; }
    public Specifications Specifications { get; set; }

    public Equipment(int id, string name, string picture, Status status, Type type, DateTime yearSupply, string codeOfManagement, Supplier supplier, Specifications specifications, int specificationId, int supplierId)
    {
        Id = id;
        Name = name;
        Picture = picture;
        Status = status;
        Type = type;
        YearSupply = yearSupply;
        CodeOfManagement = codeOfManagement;
        Supplier = supplier;
        Specifications = specifications;
        SpecificationId = specificationId;
        SupplierId = supplierId;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Equipment() { }

    public Equipment(string name)
    {
        Name = name;
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


}

