using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg;
using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.ArticleCategoryAgg
{
    public interface IArticleCategoryService
    {
        Task AddAsync(CreateArticleCategoryCommand create,
         CancellationToken cancellationToken = default);
        Task Update(UpdateArticleCategoryCommand update,
            CancellationToken cancellationToken = default);
        Task Delete(DeleteArticleCategoryCommand delete,
            CancellationToken cancellationToken = default);
        Task<Article> GetByIdAsync(int id,
            CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Article>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
