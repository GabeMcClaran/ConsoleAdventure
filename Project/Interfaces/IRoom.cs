using System.Collections.Generic;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project.Interfaces
{
    public interface IRoom
    {
        bool Locked { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        List<Item> Items { get; set; }
        Dictionary<string, IRoom> Exits { get; set; }
        Dictionary<Item, string> usables { get; set; }

    }
}
