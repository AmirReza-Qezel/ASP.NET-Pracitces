using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace EntityFrameworkPracticing
{
    //public class PeopleContextFactory : IDesignTimeDbContextFactory<PeopleContext>
    //{
    //    public PeopleContext CreateDbContext(string[] args)
    //    {
    //        var configuration = new ConfigurationBuilder()
    //        .AddJsonFile("appsettings.json")
    //        .Build();

    //        var optionsBuilder = new DbContextOptionsBuilder<PeopleContext>();
    //        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

    //        var context = new PeopleContext(optionsBuilder.Options);
    //        return context;
    //    }
    //}
}
