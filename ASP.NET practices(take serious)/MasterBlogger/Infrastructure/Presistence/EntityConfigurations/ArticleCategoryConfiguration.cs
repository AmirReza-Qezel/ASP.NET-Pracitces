using Domain.ArticleCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistence.EntityConfigurations
{
    public class ArticleCategoryConfiguration : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.HasKey(ac => ac.Id);
            builder.Property(ac => ac.Title).IsRequired().HasMaxLength(100);
            builder.Property(ac => ac.CreationDate).HasDefaultValueSql("GETDATE()");
        }
    }
}
