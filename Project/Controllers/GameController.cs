using System;
using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project.Controllers
{

    public class GameController : IGameController
    {
        private GameService _gameService { get; set; } = new GameService();
        private bool _running = true;

        //NOTE Makes sure everything is called to finish Setup and Starts the Game loop
        public void Run()
        {
            System.Console.WriteLine("Enter your name.");
            string name = Console.ReadLine();
            _gameService.Setup(name);
            System.Console.WriteLine($"Welcome {name} Hopefully you make it out alive....");
            _gameService.PrintMenu();

            while (_running)
            {

                Print();
                GetUserInput();
            }
            Console.Clear();
            Console.WriteLine("Thanks for playing");




        }

        //NOTE Gets the user input, calls the appropriate command, and passes on the option if needed.
        public void GetUserInput()
        {
            Console.WriteLine("What would you like to do?");
            string input = Console.ReadLine().ToLower() + " ";
            string command = input.Substring(0, input.IndexOf(" "));
            string option = input.Substring(input.IndexOf(" ") + 1).Trim();
            switch (input)
            {
                case "Q":
                case "Quit":
                case "Exit":
                    _running = false;
                    break;


                    // case "": 
                    //     _gameService.Inventory();
                    //     Print();
                    //     Console.ReadLine();
                    //     Console.Clear();
                    // default:
            }
            //NOTE this will take the user input and parse it into a command and option.
            //IE: take silver key => command = "take" option = "silver key"

        }

        //NOTE this should print your messages for the game.
        private void Print()
        {
            foreach (string message in _gameService.Messages)
            {
                Console.WriteLine(message);
            }
            _gameService.Messages.Clear();

        }

    }
}