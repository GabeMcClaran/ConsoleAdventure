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
                Messages.Add($"You are in the {_game.CurrentRoom.Name}");
                Messages.Add($"{_game.CurrentRoom.Description}");
                foreach (var item in _game.CurrentRoom.Items)
                    Messages.Add($"You notice a {item.Name} that might come in handy.");

            }
            else
            {
                System.Console.WriteLine("not a valid command");
            }



        }
        public void Help()
        {
            Messages.Add("Type Restart to start over, Leave to exit game, look for description of room, inventory to view inventory.");

        }

        public void Inventory()
        {
            if (_game.CurrentPlayer.Inventory == null)
            {
                Messages.Add("no items to use.");
                return;
            }
            else

                foreach (Item i in _game.CurrentPlayer.Inventory)
                {
                    Messages.Add($"You have a {i.Name}.");


                }



        }

        public void Look()
        {

            Messages.Add(_game.CurrentRoom.Description);

        }
        ///<summary>
        ///Restarts the game 
        ///</summary>
        public void Reset()
        {
            //NOTE not required for pass so save this for later
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

            Item takenItem = _game.CurrentRoom.Items.Find(i => i.Name == itemName);
            if (takenItem == null)
            {
                Messages.Add("no such item");
                return;
            }
            else
            {


                _game.CurrentPlayer.Inventory.Add(takenItem);


                Messages.Add($"You found a {itemName}, and notice a door to the south that is locked.");
                _game.CurrentRoom.Items.Remove(takenItem);
            }

        }
        ///<summary>

        ///</summary>
        public void UseItem(string itemName)
        {
            Item usedItem = _game.CurrentPlayer.Inventory.Find(i => i.Name == itemName);

            if (usedItem == null)
            {
                Messages.Add("you dont have anything to use.");
                return;
            }
            else if (usedItem.Name == itemName)
            {

                Messages.Add($"You unlocked the door to the south and can escape.");

            }

        }


        public void PrintMenu()
        {
            Messages.Add("-----Grimtol Menu-----");
            Messages.Add($"{_game.CurrentRoom.Description}");

        }

    }
}