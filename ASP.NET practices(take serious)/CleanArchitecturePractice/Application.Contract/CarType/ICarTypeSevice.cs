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
        void Create(CreateCarType command);
        void Edit(EditCarType command);
        void Remove(RemoveCarType command);
        CarTypeViewModel GetCarTypeById(int id);
        List<CarViewModel> GetAllCarTypes();
    }
}
