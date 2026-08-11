using Application.Contract.ArticleAgg.Commands;
using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.ArticleAgg
{
    public interface IArticleService
    {
        Task AddAsync(CreateArticleCommand create,
            CancellationToken cancellationToken = default);
        Task Update(UpdateArticleCommand update,
            CancellationToken cancellationToken = default);
        Task Delete(DeleteArticleCommand delete,
            CancellationToken cancellationToken = default);
        Task<Article> GetByIdAsync(int id,
            CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Article>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
