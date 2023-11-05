using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeviceManagement2.Infrastructure.EntityTypeConfigurations;
public class EquipmentInstanceEntityTypeConfiguration : IEntityTypeConfiguration<EquipmentInstance>
{
    public void Configure(EntityTypeBuilder<EquipmentInstance> builder)
    {
        builder.HasKey(ei => ei.Id);
    }
}
    
    

