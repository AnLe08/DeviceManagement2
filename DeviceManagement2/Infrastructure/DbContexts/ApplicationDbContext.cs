using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.EntityTypeConfigurations;
using DeviceManagement2.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement2.Infrastructure.DbContexts;

public class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<Lending> Lendings { get; set; }
    public DbSet<LendingFromOutsider> LendingFromOutsiders { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Specifications> Specifications { get; set; }   
    public DbSet<EquipmentInstance> EquipmentInstances { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EquipmentEntityTypeConfigurations());
        modelBuilder.ApplyConfiguration(new LendingEntityTypeConfigurations());
        modelBuilder.ApplyConfiguration(new LendingFromOutsiderEntityTypeConfigurations());
        modelBuilder.ApplyConfiguration(new ProjectEntityTypeConfigurations());
        modelBuilder.ApplyConfiguration(new SupplierEntityTypeConfigurations());
        modelBuilder.ApplyConfiguration(new SpecificationsEntityTypeConfigurations());
        modelBuilder.ApplyConfiguration(new EquipmentInstanceEntityTypeConfiguration());

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging(); // do ko làm việc trực tiếp với sql server nên ta sd logging
                                                     // để coi nó hoạt động như nào và nó tạo ra những câu truy vấn ra làm sao
    }
}
