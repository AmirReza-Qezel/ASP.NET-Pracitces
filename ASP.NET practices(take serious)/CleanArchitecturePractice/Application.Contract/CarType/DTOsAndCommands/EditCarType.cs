using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.CarType.DTOsAndCommands
{
    public class EditCarType : CreateCarType
    {
        public int Id { get; set; }
    }
}
