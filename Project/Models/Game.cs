using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
    public class Game : IGame
    {
        public IRoom CurrentRoom { get; set; }

        public IPlayer CurrentPlayer { get; set; }

        //NOTE Make yo rooms here...


        public void Setup()
        {
            Room Starting = new Room("Starting room", "You are in a unfamilliar bedroom Lights flickering, its cold, and has a moist musky odor. You notice a door to your north and a door to the east.");
            Room Kitchen = new Room("Kitchen", "The sink has a slow drip and there is a dimly lit candle table near door that looks like it hasnt been open in some time and a door open near the fridge.");
            Room Bathroom = new Room("Bathroom", "The Bathroom smells of human excriment and you notice the shower curtain is torn half way down and has dark red stain splatters on it.");
            Room Bedroom = new Room("Bedroom", "Lights are off and there is light switch near wall that appears to be getting soaked from apparent leaks in the roof");
            Room Porch = new Room("Porch", "Screened porch with a rocking chair that is for some reason rocking on its own");
            Room Bedroom2 = new Room("Bedroom2", "horrid smell of feces and rot is strong and it is dimly lit from one window with tattered blinds.");
            Room Escape = new Room("Escape", "Freedom...");

            //Create Room Relationships
            Starting.AddExits(Kitchen);
            Starting.AddExits(Porch);
            Kitchen.AddExits(Bedroom2);
            Kitchen.AddExits(Bathroom);
            Bathroom.AddExits(Kitchen);
            Bathroom.AddExits(Bedroom);
            Bedroom.AddExits(Bathroom);
            Bedroom.AddExits(Starting);
            Porch.AddExits(Kitchen);
            Porch.AddExits(Escape);

            // Add Area that Items can be picked up

            Kitchen.Items.Add(new Item("Candle", "Used to Light the Room to find the Keys."));
            Bedroom.Items.Add(new Item("Ring of Two Keys", "Gives ability to unlock 2 doors."));

            CurrentRoom = Starting;

            ;
        }
        public Game()
        {

            Setup();

        }
    }
}