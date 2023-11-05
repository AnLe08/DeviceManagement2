using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeviceManagement2.Infrastructure.EntityTypeConfigurations;

public class LendingFromOutsiderEntityTypeConfigurations : IEntityTypeConfiguration<LendingFromOutsider>
{
    public void Configure(EntityTypeBuilder<LendingFromOutsider> builder)
    {
        builder.HasKey(le => le.Id);
        builder.HasMany(le => le.Equipment).WithOne().OnDelete(DeleteBehavior.ClientSetNull).IsRequired();
        builder.HasOne(le => le.Project).WithOne().IsRequired().HasForeignKey<LendingFromOutsider>(le => le.ProjectId);

        builder.Property(le => le.Id).HasMaxLength(30).IsRequired().ValueGeneratedOnAdd();
        builder.Property(le => le.LendingedDate).IsRequired();
        builder.Property(le => le.ReturnedDate).IsRequired();
        builder.Property(le => le.Borrower).HasMaxLength(100).ValueGeneratedOnAdd().IsRequired();
        builder.Property(le => le.Reason).HasMaxLength(100).IsRequired();
        builder.Property(le => le.LoanCouponCode).HasMaxLength(100).IsRequired();
    }
}