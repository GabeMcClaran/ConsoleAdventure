using System;
using System.Collections.Generic;
using ConsoleAdventure.Project.Controllers;
using ConsoleAdventure.Project.Interfaces;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project
{
    public class GameService : IGameService
    {
        private IGame _game { get; set; }

        public List<string> Messages { get; set; }
        public GameService()
        {
            _game = new Game();
            Messages = new List<string>();
        }
        public void Go(string direction)
        {
            if (_game.CurrentRoom.Exits.ContainsKey(direction))
            {
                _game.CurrentRoom = _game.CurrentRoom.Exits[direction];
                Console.Clear();
                Messages.Add($"{_game.CurrentRoom.Description}");

            }
            else
            {
                System.Console.WriteLine("not a valid direction");
            }



        }
        public void Help()
        {
            Messages.Add("Type Restart to start over, Leave to exit game, look for description of room, inventory to view inventory.");

        }

        public void Inventory()
        {
            throw new System.NotImplementedException();
        }

        public void Look()
        {
            throw new System.NotImplementedException();
        }

        public void Quit()
        {

        }
        ///<summary>
        ///Restarts the game 
        ///</summary>
        public void Reset()
        {
            Console.Clear();
            PrintMenu();

        }

        public void Setup(string playerName)

        {
            string CurrentPlayer = playerName;



        }
        ///<summary>When taking an item be sure the item is in the current room before adding it to the player inventory, Also don't forget to remove the item from the room it was picked up in</summary>
        public void TakeItem(string itemName)
        {
            if (_game.CurrentRoom.Items.Count == 0)
            {
                Messages.Add(new string("No Items to use in this room."));
                return;
            }
            Messages.Add(new string($"There appears to be something of use in this room"));
            // Player.Inventory.AddRange(_game.CurrentPlayer.Inventory);
            throw new System.NotImplementedException();
        }
        ///<summary>
        ///No need to Pass a room since Items can only be used in the CurrentRoom
        ///Make sure you validate the item is in the room or player inventory before
        ///being able to use the item
        ///</summary>
        public void UseItem(string itemName)
        {

            throw new System.NotImplementedException();
        }
        //Below are methods added beyond given//

        public void PrintMenu()
        {
            Messages.Add("-----Grimtol Menu-----");
            Messages.Add($"{_game.CurrentRoom.Description}");

        }

    }
}