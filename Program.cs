using System;
using ConsoleAdventure.Project;
using ConsoleAdventure.Project.Controllers;

namespace ConsoleAdventure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@"
.____           _____  __      _____              ________                     .___
|    |    _____/ ____\/  |_  _/ ____\___________  \______ \   ____ _____     __| _/
|    |  _/ __ \   __\\   __\ \   __\/  _ \_  __ \  |    |  \_/ __ \\__  \   / __ | 
|    |__\  ___/|  |   |  |    |  | (  <_> )  | \/  |    `   \  ___/ / __ \_/ /_/ | 
|_______ \___  >__|   |__|    |__|  \____/|__|    /_______  /\___  >____  /\____ | 
        \/   \/                                           \/     \/     \/      \/ 
");
            GameController gc = new GameController();
            gc.Run();
        }
    }
}
