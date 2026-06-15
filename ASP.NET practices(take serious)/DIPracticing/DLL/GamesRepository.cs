using DIPracticing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPracticing.DLL
{
    public class GameRepository : IGameRepository
    {
        List<Game> games = new List<Game>
        {
                new Game { Id = 1, Title = "The Witcher 3", Genre = "RPG", Price = 29.99 },
                new Game { Id = 2, Title = "Minecraft", Genre = "Sandbox", Price = 19.99 },
                new Game { Id = 3, Title = "FIFA 24", Genre = "Sports", Price = 59.99 },
                new Game { Id = 4, Title = "Call of Duty", Genre = "FPS", Price = 69.99 },
                new Game { Id = 5, Title = "Stardew Valley", Genre = "Simulation", Price = 14.99 }
        };

        public List<Game> GetAllGames()
        {
            return games;
        }
        public Game FindGameBy(int id)
        {
            var game = GetAllGames().FirstOrDefault(x => x.Id == id);
            return game;
        }
    }
}
