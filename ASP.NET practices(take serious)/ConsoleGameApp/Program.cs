using ConsoleGameApp.BLL;
using ConsoleGameApp.DLL;
using ConsoleGameApp.Helpers;

GameService gameService = new GameService(new GameRepository(),new Logger());
Console.WriteLine(gameService.LaunchGame());