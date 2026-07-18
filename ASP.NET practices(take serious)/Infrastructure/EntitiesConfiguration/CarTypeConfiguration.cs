using Domain.CarTypeAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntitiesConfiguration
{
    internal class CarTypeConfiguration : IEntityTypeConfiguration<CarType>
    {
        public void Configure(EntityTypeBuilder<CarType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasMany(x => x.Cars)
                .WithMany(c => c.CarTypes);
        }
    }
}
