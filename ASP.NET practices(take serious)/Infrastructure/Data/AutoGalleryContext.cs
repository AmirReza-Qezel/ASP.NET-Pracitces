using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.CarAgg;
using Domain.CarTypeAgg;

namespace Infrastructure.Data
{
    public class AutoGalleryContext : DbContext
    {
        public AutoGalleryContext(DbContextOptions<AutoGalleryContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
    }
}
