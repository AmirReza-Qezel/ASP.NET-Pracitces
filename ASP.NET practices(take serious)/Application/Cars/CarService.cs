using Application.Contract.Car;
using Application.Contract.Car.DTOsAndCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.CarAgg;
using Domain.CarTypeAgg;
using Application.Cars.Mappings;

namespace Application.Cars
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task Create(CreateCar command)
        {
            var isDuplicate = await _carRepository.ExistsAsync(command.Name, command.Description, command.Price);
            if (isDuplicate)
            {
                return;
            }
            var car = new Car(command.Name, command.Description, command.Price); 
            _carRepository.AddAsync(car);
            _carRepository.SaveChanges();
        }

        public async Task Edit(EditCar command)
        {
            var car = await _carRepository.GetByIdAsync(command.Id);
            if (car == null)
            {
                return;
            }
            _carRepository.Update(car);
            _carRepository.SaveChanges();

        }

        public async Task<List<CarViewModel>> GetAllCars()
        {
            var cars = await _carRepository.GetAllAvailableCarsAsync();
            return cars.MapToViewModelList();
        }

        public async Task<CarViewModel> GetCarDetailsById(int id)
        {
            var car = await _carRepository.GetByIdAsync(id);
            return car.MapToViewModel();
        }

        public async void Remove(RemoveCar command)
        {
            var car = await _carRepository.GetByIdAsync(command.Id);
            if (car == null) return;
            _carRepository.Remove(car);
        }
    }
}
