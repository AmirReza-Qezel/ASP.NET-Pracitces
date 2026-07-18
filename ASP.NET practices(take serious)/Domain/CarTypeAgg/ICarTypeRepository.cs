using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CarTypeAgg
{
    public interface ICarTypeRepository
    {
        Task<CarType> GetCarTypeById(int id);
        Task<IReadOnlyList<CarType>> GetAllActiveCarTypes();

        Task AddAsync (CarType carType);
        void Update(CarType carType);
        void Remove(CarType cartype);
        Task<bool> IsCodeUniqueAsync (string code);
        Task SaveChanges();
    }
}
