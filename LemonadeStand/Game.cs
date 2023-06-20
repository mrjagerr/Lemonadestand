using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        Player player1 =new Player();
        //[8:20 PM] step2 Start first day
        
        //[8:21 PM] 2.2 Display the player's inventory.
        //[8:21 PM] 2.3 Allow the player to go to the store to get ingredients (edited)
        //[8:21 PM] 2.4  Allow player to edit the recipe for more of each item (edited)
        //[8:23 PM] 2.5 Display actual forecast for the day
        //[8:24 PM] 2.6 State the number of cups that a pitcher pours.
        //[8:25 PM] 2.7 Select price per cup.
        //[8:25 PM] 2.8 State the weather and temp to signify the weather of the day
        //[8:26 PM] 2.9 Customer buy loop on a random purchase
        //[8:27 PM] 2.10 Finish first day with results of sales and number of cups sold. As well as the amount made that day.
        //[8:28 PM] step 3 Repeat of step 2.1-2.10 (edited)
        //[8:29 PM] step 4 Repeat of 7 times with for each loop
        //[8:29 PM] //for each day do this

       
       






        public Game()
        {

        }

        //        step 1. Display the message explaining the game.
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Lemonade Stand!\r\n" +
                "You have seven days to make as much money as you possibly can.\r\n" +
                "The weather, along it the pricing of your lemonade, will affect you succsess.\r\n" +
                "Can you bring home the bacon!");
        }
        public void DailyWeather()
        {
            //[8:21 PM] 2.1 Display the forecast prediction
            Day day = new Day();
            Console.WriteLine($"It is currently Day{day.DayCounter}.");
            

        }
        public void  PlayerInventory()
        {
            
            Inventory inventory = new Inventory();
            player1.inventory = inventory;
            Console.WriteLine($" You currently have {player1.wallet.Money} $");
            Console.WriteLine($" You currently have {player1.inventory.lemons.Count} lemons.");
            Console.WriteLine($" You currently have {player1.inventory.sugarCubes.Count} sugar cubes.");
            Console.WriteLine($" You currently have {player1.inventory.iceCubes.Count} ice cubes.");
            Console.WriteLine($" You currently have {player1.inventory.cups.Count} cups.");
        }

        public void PurchaseIngrediants() 
        {
            Store store = new Store();
          
            store.SellCups(player1);
            store.SellIceCubes(player1);
            store.SellLemons(player1);
            store.SellSugarCubes(player1);
     
        }
        public void LemonadeRecipe()
        {
            Recipe  recipe1 = new Recipe();
            player1.recipe= recipe1;
            recipe1.DisplayRecipe();

            Console.WriteLine("Would you like change the Lemonade Recipe. Y/N ");
            string response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                Console.WriteLine("How many lemons would you like to use?");
                recipe1.numberOfLemons = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many sugarcubes would you like to use?");
                recipe1.numberOfSugarCubes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many icecubes would you like to use?");
                recipe1.numberOfIceCubes = Convert.ToInt32(Console.ReadLine());
                


            }
            else if (Console.ReadLine() == "N")
            {
                return;
            }


        }
       






        


        public void RunGame()
        {

            WelcomeMessage();
            
            DailyWeather();
            PlayerInventory();
            PurchaseIngrediants();
            //PlayerInventory();
            LemonadeRecipe();
            
        }


    }











    











}
