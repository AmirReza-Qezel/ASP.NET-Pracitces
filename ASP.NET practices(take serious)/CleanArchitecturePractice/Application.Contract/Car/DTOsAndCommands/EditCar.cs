using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.Car.DTOsAndCommands
{
    public class EditCar : CreateCar
    {
        public int Id { get; set; }
    }
}
