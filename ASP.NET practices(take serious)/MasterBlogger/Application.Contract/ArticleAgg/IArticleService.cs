using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg.Commands___DTOs;
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
        Task<ArticleDTO> GetByIdAsync(int id,
            CancellationToken cancellationToken = default);
        Task<IReadOnlyList<ArticleDTO>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
