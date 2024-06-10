using DeviceManagement2.Applicaiton.Services;
using DeviceManagement2.Controllers;
using DeviceManagement2.Domain.Repositories;
using DeviceManagement2.Infrastructure.DbContexts;
using DeviceManagement2.Infrastructure.Repositories;
using DeviceManagement2.Models;
using DeviceManagement2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddScoped<IEquipmentInstanceRepository, EquipmentInstanceRepository>();
builder.Services.AddScoped<ILendingFromOutsiderRepository, LendingFromOutsiderRepository>();
builder.Services.AddScoped<ILendingRepository, LendingRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<ISpecificationsRepository, SpecificationsRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();

builder.Services.AddTransient<ILendingService, LendingService>();
builder.Services.AddTransient<ILendingFromOutsiderService, LendingFromOutsiderService>();
builder.Services.AddTransient<IProjectService, ProjectService>();
builder.Services.AddTransient<ISpecificationsService, SpecificationsService>();
builder.Services.AddTransient<ISupplierService, SuplierService>();
builder.Services.AddTransient<IEquipmentService, EquipmentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
