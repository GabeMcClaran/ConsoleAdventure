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
            Room Kitchen = new Room("Kitchen", "The sink has a slow drip and there is a dimly lit candle with a flashlight near it on the kitchen table. You also notice a door your north that looks like it hasnt been open in some time. You also notice a door open to your east near the fridge.");
            Room Bathroom = new Room("Bathroom", "The Bathroom smells of human excriment and you notice the shower curtain is torn half way down and has dark red stain splatters on it. There is a door that is ajar to the south.");
            Room Bedroom = new Room("Bedroom", "Lights are off, it is to dark to see anything, only if you had a lightsource...");
            Room Porch = new Room("Porch", "Screened porch with a rocking chair that is for some reason rocking on its own");
            Room Bedroom2 = new Room("Bedroom2", "horrid smell of feces and rot is strong and it is dimly lit from one window with tattered blinds.");
            Room Escape = new Room("Escape", "Freedom...");

            //Create Room Relationships
            Starting.Exits.Add("north", Kitchen);
            Starting.Exits.Add("south", Porch);
            Kitchen.Exits.Add("north", Bedroom2);
            Kitchen.Exits.Add("east", Bathroom);
            Bathroom.Exits.Add("west", Kitchen);
            Bathroom.Exits.Add("south", Bedroom);
            Bedroom.Exits.Add("north", Bathroom);
            Bedroom.Exits.Add("west", Starting);
            Porch.Exits.Add("north", Starting);
            Porch.Exits.Add("south", Escape);

            // Add Area that Items can be picked up

            Kitchen.Items.Add(new Item("Candle", "Used to Light the Room to find the Keys."));
            Bedroom.Items.Add(new Item("Ring of Two Keys", "Gives ability to unlock 1 door."));

            CurrentRoom = Starting;


        }
        public Game()
        {

            Setup();

        }
    }
}