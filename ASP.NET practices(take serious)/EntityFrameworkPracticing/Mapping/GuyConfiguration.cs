using EntityFrameworkPracticing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkPracticing.Mapping
{
    public class GuyConfiguration : IEntityTypeConfiguration<Guy>
    {
        public void Configure(EntityTypeBuilder<Guy> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
