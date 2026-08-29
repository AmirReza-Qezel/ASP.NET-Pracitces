using Application.Contract.ArticleCategoryAgg;
using Application.ArticleCategoryAgg;
using Microsoft.Extensions.DependencyInjection;
using Application.Contract.ArticleAgg;
using Application.ArticleAgg;
using Application.ArticleCategoryCategoryAgg;
using Domain.ArticleAgg;
using Infrastructure.Presistence.Repositories;
using Domain.Common;
using Domain.ArticleCategoryAgg;
using Domain.JournalistAgg;
using Domain.CommentAgg;
using Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Infrastructure.Core
{
    public static class Bootstrapper
    {
        public static void RegisterAll(this IServiceCollection services, IConfiguration configuration)
        {
            ApplicationRegister(services);
            InfrastructureRegister(services,configuration);
        }
        public static void ApplicationRegister(IServiceCollection services)
        {
            services.AddScoped<IArticleService,ArticleService>();
            services.AddScoped<IArticleCategoryService,ArticleCategoryService>();
        }
        public static void DomainRegister(IServiceCollection services)
        {
            //services.AddScoped<IRepository<Article>, ArticleRepository>();
            //services.AddScoped<IRepository<ArticleCategory>, ArticleCategoryRepository>();
            //services.AddScoped<IRepository<Journalist>, JournalistRepository>();
            //services.AddScoped<IRepository<Comment>, CommentRepository>();

        }
        public static void InfrastructureRegister(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MasterBloggerContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("default")));

            services.AddScoped<IRepository<Article>, ArticleRepository>();
            services.AddScoped<IRepository<ArticleCategory>, ArticleCategoryRepository>();
            services.AddScoped<IRepository<Journalist>, JournalistRepository>();
            services.AddScoped<IRepository<Comment>, CommentRepository>();
        }
    }
}
