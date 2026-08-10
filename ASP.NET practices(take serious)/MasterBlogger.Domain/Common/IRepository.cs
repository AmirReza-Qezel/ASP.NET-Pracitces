using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByIdAsync (int id, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAllAsync (CancellationToken cancellationToken);
        Task AddAsync (T item, CancellationToken cancellationToken);
        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}
