using Domain.JournalistAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistence.EntityConfigurations
{
    public class JournalistConfiguration : IEntityTypeConfiguration<Journalist>
    {
        public void Configure(EntityTypeBuilder<Journalist> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(j => j.LastName).IsRequired().HasMaxLength(100);
            builder.Property(j => j.MembershipDate).HasDefaultValueSql("GETDATE()");
        }
    }
}
