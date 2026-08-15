using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }

        // Constructor with entity name and key
        public NotFoundException(string entityName, object key)
            : base($"Entity \"{entityName}\" with key ({key}) was not found.")
        {
        }

        // Constructor with inner exception
        public NotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
