using Application.Contract.Car.DTOsAndCommands;
using Application.Contract.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contract.CarType.DTOsAndCommands;

namespace Application.Contract.CarType
{
    public interface ICarTypeSevice
    {
        Task Create(CreateCarType command);
        Task Edit(EditCarType command);
        Task Remove(RemoveCarType command);
        Task<CarTypeViewModel> GetCarTypeById(int id);
        Task<IEnumerable<CarTypeViewModel>> GetAllCarTypes();
    }
}
