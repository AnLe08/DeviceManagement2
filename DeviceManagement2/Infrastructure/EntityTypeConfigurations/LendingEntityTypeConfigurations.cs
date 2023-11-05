using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeviceManagement2.Infrastructure.EntityTypeConfigurations;

public class LendingEntityTypeConfigurations : IEntityTypeConfiguration<Lending>
{
    public void Configure(EntityTypeBuilder<Lending> builder)
    {
        builder.HasKey(l => l.Id);
        builder.HasMany(l => l.Equipment).WithOne().OnDelete(DeleteBehavior.ClientSetNull).IsRequired();
        builder.HasOne(l => l.Project).WithOne().IsRequired().HasForeignKey<Lending>(l => l.ProjectId);
        builder.Property(l => l.LendingedDate).IsRequired();
        builder.Property(l => l.Borrower).IsRequired();
        builder.Property(l => l.Reason).IsRequired();
    }
}