using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
    public class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public Dictionary<string, IRoom> Exits { get; set; }
        public bool Locked { get; set; }


        public void AddExits(Room des)
        {
            Exits.Add(des.Name, des);

        }
        public Room(string name, string description)
        {
            Locked = Locked;
            Name = name;
            Description = description;
            Exits = new Dictionary<string, IRoom>();
            Items = new List<Item>();
        }
    }

}