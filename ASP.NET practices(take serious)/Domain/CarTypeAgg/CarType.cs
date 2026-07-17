using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CarTypeAgg
{
    internal class CarType
    {
        public int Id { get; private set; }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public bool IsActive { get; private set; }
        public bool IsRemoved { get; private set; }

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
