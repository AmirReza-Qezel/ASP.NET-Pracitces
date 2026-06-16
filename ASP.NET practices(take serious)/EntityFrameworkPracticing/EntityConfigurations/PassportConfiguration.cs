using EntityFrameworkPracticing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkPracticing.EntityConfigurations
{
    public class PassportConfiguration : IEntityTypeConfiguration<Passport>
    {
        public void Configure(EntityTypeBuilder<Passport> builder)
        {
            builder.HasOne(p => p.Guy)
                .WithOne(x => x.Passport)
                .HasForeignKey<Passport>(p => p.GuyId);
        }
    }
}
