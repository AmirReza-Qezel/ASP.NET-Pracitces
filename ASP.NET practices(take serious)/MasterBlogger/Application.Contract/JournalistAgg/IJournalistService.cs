using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg;
using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contract.JournalistAgg.Commands___DTOs;

namespace Application.Contract.JournalistAgg
{
    public interface IJournalistService
    {
        Task AddAsync(CreateJournalistCommand create,
         CancellationToken cancellationToken = default);
        Task Update(UpdateJournalistCommand update,
            CancellationToken cancellationToken = default);
        Task Delete(DeleteJournalistCommand delete,
            CancellationToken cancellationToken = default);
        Task<JournalistDTO> GetByIdAsync(int id,
            CancellationToken cancellationToken = default);
        Task<IReadOnlyList<JournalistDTO>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
