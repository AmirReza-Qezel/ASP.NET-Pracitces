using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByIdAsync (int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetAllAsync (CancellationToken cancellationToken = default);
        Task AddAsync (T item, CancellationToken cancellationToken = default);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
