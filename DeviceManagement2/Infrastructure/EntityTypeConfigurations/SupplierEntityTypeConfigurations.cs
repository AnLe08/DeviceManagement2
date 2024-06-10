using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeviceManagement2.Infrastructure.EntityTypeConfigurations;

public class SupplierEntityTypeConfigurations : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.HasKey(s => s.Id);
        builder.HasOne(s => s.EquipmentId).WithOne(e => e.Supplier).HasForeignKey<Equipment>(e => e.SupplierId);

        builder.Property(s => s.Id).HasMaxLength(100).IsRequired();
        builder.Property(s => s.Name).HasMaxLength(100).IsRequired();
        builder.Property(s => s.Addresses).HasMaxLength(100).IsRequired();
        builder.Property(s => s.PhoneNumber).HasMaxLength(50).IsRequired();
        builder.Property(s => s.Email).HasMaxLength(100).IsRequired();
    }
}
