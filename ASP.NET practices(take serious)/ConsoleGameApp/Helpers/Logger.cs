using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameApp.Helpers
{
    public class Logger : ILogger
    {
        public void Logg(string messsage)
        {
            Console.WriteLine(messsage);
        }
    }
}
