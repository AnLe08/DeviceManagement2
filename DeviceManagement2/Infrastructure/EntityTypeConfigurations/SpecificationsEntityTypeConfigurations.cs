using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeviceManagement2.Infrastructure.EntityTypeConfigurations;

public class SpecificationsEntityTypeConfigurations : IEntityTypeConfiguration<Specifications>
{
    public void Configure(EntityTypeBuilder<Specifications> builder)
    {
        builder.HasKey(sp => sp.Id);
        builder.HasOne(sp => sp.EquipmentId).WithOne(p => p.Specifications).HasForeignKey<Equipment>(p => p.SpecificationId); 

        builder.Property(sp => sp.Id).HasMaxLength(100);
        builder.Property(sp => sp.Name).HasMaxLength(100).IsRequired();
        builder.Property(sp => sp.Value).HasMaxLength(100).IsRequired();
    }
}
