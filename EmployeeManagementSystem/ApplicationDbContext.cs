using EmployeeManagementSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }

    }
}
