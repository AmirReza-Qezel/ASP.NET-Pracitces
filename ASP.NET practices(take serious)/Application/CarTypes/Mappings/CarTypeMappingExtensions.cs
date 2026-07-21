using Application.Contract.Car;
using Application.Contract.CarType;
using Domain.CarAgg;
using Domain.CarTypeAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.CarTypes.Mappings
{
    public static class CarTypeMappingExtensions
    {
        public static CarTypeViewModel MapToViewModel(this CarType carType)
        {
            if (carType == null) return null;
            return new CarTypeViewModel
            {
               Id = carType.Id,
               Code = carType.Code,
               Name = carType.Name,
               Description = carType.Description
            };
        }
        public static List<CarTypeViewModel> MapToViewModelList(this IReadOnlyList<CarType> carTypes)
        {
            return carTypes.Select(c => c.MapToViewModel()).ToList();
        }
    }
}
