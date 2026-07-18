using Domain.CarAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CarTypeAgg
{
    public class CarType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public IList<Car> Cars { get; private set; } = new List<Car>();

        private CarType() { }

        public CarType(string code, string name, string? description = null)
        {
            Code = code;
            Name = name;
            Description = description;
            IsActive = true;
        }
         public void Deactivate() => IsActive = false;
    }
}
