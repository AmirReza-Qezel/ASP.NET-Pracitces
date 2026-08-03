using Application.Contract.CarType.DTOsAndCommands;
using Application.Contract.CarType;
using Application.Contract.CarType;
using Domain.CarAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.CarTypeAgg;
using Application.Contract.CarType.DTOsAndCommands;
using Application.CarTypes.Mappings;

namespace Application.CarTypes
{
    public class CarTypeService : ICarTypeSevice
    {
        private readonly ICarTypeRepository _carTypeRepository;
        public CarTypeService(ICarTypeRepository carTypeRepository)
        {
            _carTypeRepository = carTypeRepository;
        }

        public async Task Create(CreateCarType command)
        {
            var isDuplicate = await _carTypeRepository.IsCodeUniqueAsync(command.Code);
            if (isDuplicate)
            {
                return;
            }
            var carType = new CarType(command.Code,command.Name,command.Description);
            _carTypeRepository.AddAsync(carType);
            _carTypeRepository.SaveChanges();
        }

        public async Task Edit(EditCarType command)
        {
            var carType = await _carTypeRepository.GetCarTypeById(command.Id);
            if (carType == null)
            {
                return;
            }
            _carTypeRepository.Update(carType);
            _carTypeRepository.SaveChanges();

        }

        public async Task<IEnumerable<CarTypeViewModel>> GetAllCarTypes()
        {
            var cars = await _carTypeRepository.GetAllActiveCarTypes();
            return cars.MapToViewModelList();
        }

        public async Task<CarTypeViewModel> GetCarTypeById(int id)
        {
            var carType = await _carTypeRepository.GetCarTypeById(id);
            return carType.MapToViewModel();
        }

        public async Task Remove(RemoveCarType command)
        {
            var carType = await _carTypeRepository.GetCarTypeById(command.Id);
            if (carType == null) return;
            _carTypeRepository.Remove(carType);
        }
    }
}
