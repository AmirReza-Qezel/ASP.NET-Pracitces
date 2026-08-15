using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg;
using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ArticleCategoryAgg;
using Application.Contract.ArticleCategoryAgg.Commands___DTOs;

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
        Task<ArticleCategoryDTO> GetByIdAsync(int id,
            CancellationToken cancellationToken = default);
        Task<IReadOnlyList<ArticleCategoryDTO>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
