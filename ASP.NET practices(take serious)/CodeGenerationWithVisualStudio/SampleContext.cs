using CodeGenerationWithVisualStudio.EntityConfigurations;
using CodeGenerationWithVisualStudio.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeGenerationWithVisualStudio
{
    public class SampleContext :DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options):base(options) { }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}
