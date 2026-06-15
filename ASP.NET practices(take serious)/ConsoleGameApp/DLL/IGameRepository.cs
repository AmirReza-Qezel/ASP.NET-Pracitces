using ConsoleGameApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameApp.DLL
{
    public interface IGameRepository
    {
         public List<Game> GetAllGames();
         public Game FindGameBy(int id);
    }
}
