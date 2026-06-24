using EntityFrameworkPracticing.EntityConfigurations;
using EntityFrameworkPracticing.Mapping;
using EntityFrameworkPracticing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;

namespace EntityFrameworkPracticing
{
    public class PeopleContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Guy> Guys { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GuyConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // ✅ tells it where to look
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("PeopleDbContext"));
        }
    }
}
