using Domain.ArticleAgg;
using Domain.ArticleCategoryAgg;
using Domain.CommentAgg;
using Domain.JournalistAgg;
using Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Presistence.EntityConfigurations;

namespace Infrastructure.Presistence
{
    public class MasterBloggerContext : DbContext
    {
        public MasterBloggerContext(DbContextOptions options) : base(options) {
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Journalist> Journalists { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MasterBloggerContext).Assembly);
        }
    }
}
