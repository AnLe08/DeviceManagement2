using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeviceManagement2.Infrastructure.EntityTypeConfigurations;

public class EquipmentEntityTypeConfigurations : IEntityTypeConfiguration<Equipment>
{

    public void Configure(EntityTypeBuilder<Equipment> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasOne(e => e.Specifications).WithOne().IsRequired().HasForeignKey<Equipment>(e => e.SpecificationId);
        builder.HasOne(e => e.Supplier).WithOne().IsRequired().HasForeignKey<Equipment>(e => e.SupplierId);

        builder.Property(e => e.Id).HasMaxLength(100);
        builder.Property(e => e.SpecificationId).HasMaxLength(100).IsRequired();
        builder.Property(e => e.SupplierId).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Picture).IsRequired();
        builder.Property(e => e.Status).IsRequired();
        builder.Property(e => e.Type).IsRequired();
        builder.Property(e => e.YearSupply).IsRequired();
        builder.Property(e => e.CodeOfManagement).IsRequired();
        //builder.Property(e => e.Supplier).IsRequired();
        //builder.Property(e => e.Specifications).IsRequired();
    }
}
