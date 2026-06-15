
using DIPracticing.BLL;
using DIPracticing.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPracticing.BLL
{
    public class GameService :IGameService
    {
        public IGameRepository gameRepo { get; set; }
        public GameService(IGameRepository gameRepo)
        {
            
            this.gameRepo = gameRepo;  
        }
        public string LaunchGame()
        {
            var game = gameRepo.FindGameBy(3);
            return $"{game.Title} is about to launch";
        }
    }
}
