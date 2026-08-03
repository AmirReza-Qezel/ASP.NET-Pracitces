using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RazorBlogProject.Models;

namespace RazorBlogProject.EntityConfiguration
{
    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(20);
            builder.Property(x => x.ShortSummary).HasMaxLength(2000);
            builder.Property(x => x.PictureTitle).HasMaxLength(2000);
            builder.Property(x => x.PicturePath).HasMaxLength(2000);
            builder.Property(x => x.AltPicturePath).HasMaxLength(2000);
            builder.Property(x => x.Description).HasMaxLength(5000);
        }
    }
}
