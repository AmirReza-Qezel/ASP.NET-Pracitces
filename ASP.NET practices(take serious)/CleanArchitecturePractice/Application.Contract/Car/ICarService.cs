using Application.Contract.Car.DTOsAndCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.Car
{
    public interface ICarService
    {
        Task Create(CreateCar command);
        Task Edit(EditCar command);
        void Remove(RemoveCar command);
        Task<CarViewModel> GetCarDetailsById(int id);
        Task<List<CarViewModel>> GetAllCars();

    }
}
