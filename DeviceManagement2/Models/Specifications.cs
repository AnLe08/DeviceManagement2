namespace DeviceManagement2.Models;

public class Specifications
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public Equipment EquipmentId { get; set; }
    public Specifications(string name, string value, int id, Equipment equipmentId )
    {
        Name = name;
        Value = value;
        Id = id;
        EquipmentId = equipmentId;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Specifications() { }

    public Specifications(string name/*, int id*/)
    {
        Name = name;
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
