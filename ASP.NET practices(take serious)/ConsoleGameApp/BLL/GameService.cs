using ConsoleGameApp.DLL;
using ConsoleGameApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameApp.BLL
{
    public class GameService
    {
        public IGameRepository gameRepo { get; set; }
        public ILogger logger { get; set; }
        public GameService(IGameRepository gameRepo,ILogger logger)
        {
            this.logger = logger;
            this.gameRepo = gameRepo;  
        }
        public string LaunchGame()
        {
            var game = gameRepo.FindGameBy(3);
            return $"{game.Title} is about to launch";
        }
    }
}
