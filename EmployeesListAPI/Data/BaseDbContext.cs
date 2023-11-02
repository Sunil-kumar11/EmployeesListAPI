using EmployeesListAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EmployeesListAPI.Data
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<CodeRef> CodeRef { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
