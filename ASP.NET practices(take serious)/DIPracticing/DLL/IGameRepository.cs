using DIPracticing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPracticing.DLL
{
    public interface IGameRepository
    {
         public List<Game> GetAllGames();
         public Game FindGameBy(int id);
    }
}
