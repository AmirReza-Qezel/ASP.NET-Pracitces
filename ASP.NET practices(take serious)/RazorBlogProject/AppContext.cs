using Microsoft.EntityFrameworkCore;
using RazorBlogProject.EntityConfiguration;
using RazorBlogProject.Models;

namespace RazorBlogProject
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BlogPostConfiguration());
        }

    }
}
