using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CarAgg
{
    public interface ICarRepository
    {
        Task<Car?> GetByIdAsync(int id);
        Task<IReadOnlyList<Car>> GetAllAvailableCarsAsync();
        Task AddAsync(Car car);
        void Update(Car car);
        void Remove(Car car);
        Task<bool> ExistsAsync(string name,string description,decimal price);
        Task SaveChanges();
    }
}
