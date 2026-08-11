using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg;
using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.CommentAgg
{
    public interface ICommentService
    {
        Task AddAsync(CreateCommentCommand create,
         CancellationToken cancellationToken = default);
        Task Update(UpdateCommentCommand update,
            CancellationToken cancellationToken = default);
        Task Delete(DeleteCommentCommand delete,
            CancellationToken cancellationToken = default);
        Task<Article> GetByIdAsync(int id,
            CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Article>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
