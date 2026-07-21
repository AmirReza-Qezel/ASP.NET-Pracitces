using Application.Contract.Car;
using Domain.CarAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cars.Mappings
{
    public static class CarTypeMappingExtensions
    {
        public static CarViewModel MapToViewModel(this Car car)
        {
            if (car == null) return null;
            return new CarViewModel
            {
                Id = car.Id,
                Name = car.Name,
                Description = car.Description,
                Price = car.Price.ToString()
            };
        }
        public static List<CarViewModel> MapToViewModelList(this IReadOnlyList<Car> cars)
        {
            return cars.Select(c => c.MapToViewModel()).ToList();
        }
    }
}
