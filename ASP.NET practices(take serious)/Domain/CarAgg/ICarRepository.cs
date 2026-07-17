using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CarAgg
{
    internal interface ICarRepository
    {
        Task<Car?> GetByIdAsync(int id);
        Task<IEnumerable<Car>> GetAllAvailableCarsAsync();
        Task AddAsync(Car car);
        void Update(Car car);
        void Remove(Car car);
        Task<bool> ExistsAsync();
        Task SaveChanges();
    }
}
