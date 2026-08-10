using Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistence.EntityConfigurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Content).IsRequired().HasColumnType("nvarchar(max)");
            builder.Property(a => a.CreationDate).HasDefaultValue("GETDATE()");

            builder.HasOne(a => a.Journalist)
                .WithMany(j => j.Articles)
                .HasForeignKey(a => a.JournalistId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ArticleCategory)
                 .WithMany(ac => ac.Articles)
                 .HasForeignKey(a => a.ArticleCategoryId)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
