using Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistence.EntityConfigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AuthorName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Content).IsRequired().HasMaxLength(100);
            builder.Property(c => c.CreationDate).HasDefaultValue("GETDATE()");
        }
    }
}
