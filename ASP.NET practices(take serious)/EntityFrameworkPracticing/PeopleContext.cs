using EntityFrameworkPracticing.Mapping;
using EntityFrameworkPracticing.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPracticing
{
    public class PeopleContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Guy> Guys { get; set; }
        public DbSet<Passport> Passports { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GuyConfiguration());
        }
    }
}
