using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CarTypeAgg
{
    internal interface ICarTypeRepository
    {
        Task<CarType> GetCarTypeById(int id);
        Task<IEnumerable<CarType>> GetAllActiveCarTypes();

        Task AddAsync (CarType carType);
        void Update(CarType carType);
        void Remove(CarType cartype);
        Task<bool> IsCodeUniqueAsync (string code);
        Task SaveChanges();
    }
}
