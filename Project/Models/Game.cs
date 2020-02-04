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
            Room Bedroom = new Room("Bedroom", "You see a vacant room with a door to the west.");
            Room Porch = new Room("Porch", "Screened porch with a rocking chair that is for some reason rocking on its own");
            Room Bedroom2 = new Room("Bedroom2", "horrid smell of feces and rot is strong and it is dimly lit from one window with tattered blinds. You then notice rabid dogs snarling while running and attacking you. You Die... the end.");
            Room Escape = new Room("Escape", "Freedom... you make it out alive. You Win.");

            //Create Room Relationships
            Starting.Exits.Add("north", Kitchen);
            Kitchen.Exits.Add("north", Bedroom2);
            Kitchen.Exits.Add("east", Bathroom);
            Bathroom.Exits.Add("west", Kitchen);
            Bathroom.Exits.Add("south", Bedroom);
            Bedroom.Exits.Add("north", Bathroom);
            Bedroom.Exits.Add("west", Starting);
            Bedroom.Exits.Add("south", Escape);


            Item flashlight = new Item("flashlight", "this is item to be used to light in area you cant see.");

            Item Keys = new Item("key", "Gives ability to unlock 1 door.");
            // Add Area that Items can be picked up
            Bedroom.usables.Add(Keys, "The Door to the south is now unlocked and looks like a viable way out.");
            // Kitchen.Items.Add(flashlight);
            Bedroom.Items.Add(Keys);

            CurrentRoom = Starting;
            CurrentPlayer = new Player("player");

        }
        public Game()
        {

            Setup();

        }
    }
}