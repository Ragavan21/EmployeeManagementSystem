using EmployeeManagementSystem;
using EmployeeManagementSystem.Repository;
using EmployeeManagementSystem.Repository.Interface;
using EmployeeManagementSystem.Service;
using EmployeeManagementSystem.Service.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();



builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
