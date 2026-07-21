using Domain.CarTypeAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CarAgg
{
    public class Car
    {
        private Car() { }
        public Car(string name, string description,decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
            IsDeleted = false;
            IsActive = true;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public IList<CarType> CarTypes { get; private set; } = new List<CarType>();
    }
}
