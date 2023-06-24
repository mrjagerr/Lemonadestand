using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        Player player1 = new Player();
        
        
        
        //[8:20 PM] step2 Start first day

       
        
        //[8:23 PM] 2.5 Display actual forecast for the day
       
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
        public void DayCreation()
        {
            //[8:21 PM] 2.1 Display the forecast prediction
            Day day = new Day();
           
            Console.WriteLine($"It is currently Day{day.Daycounter}.");
            

        }
        
        public void PlayerInventory()
        {

            //[8:21 PM] 2.3 Allow the player to go to the store to get ingredients (edited)

            Console.WriteLine($" You currently have {player1.wallet.Money} $");
            Console.WriteLine($" You currently have {player1.inventory.lemons.Count} lemons.");
            Console.WriteLine($" You currently have {player1.inventory.sugarCubes.Count} sugar cubes.");
            Console.WriteLine($" You currently have {player1.inventory.iceCubes.Count} ice cubes.");
            Console.WriteLine($" You currently have {player1.inventory.cups.Count} cups.");
        }

        public void PurchaseIngrediants()
        {
            //[8:21 PM] 2.3 Allow the player to go to the store to get ingredients (edited)
            Store store = new Store();

            store.SellCups(player1);
            store.SellIceCubes(player1);
            store.SellLemons(player1);
            store.SellSugarCubes(player1);

        }
        public void LemonadeRecipe()
        {
           
            //[8:21 PM] 2.4  Allow player to edit the recipe for more of each item (edited)
           player1.recipe.DisplayRecipe();

            Console.WriteLine("Would you like change the Lemonade Recipe. Y/N ");
            string response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                Console.WriteLine("How many lemons would you like to use?");
                player1.recipe.numberOfLemons = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many sugarcubes would you like to use?");
                player1.recipe.numberOfSugarCubes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many icecubes would you like to use?");
                player1.recipe.numberOfIceCubes = Convert.ToInt32(Console.ReadLine());



            }
            else if (Console.ReadLine() == "N")
            {
                return;
            }


        }

        public void Pitchers()
        {
            //[8:24 PM] 2.6 State the number of cups that a pitcher pours.
            int numberOfPitchers = UserInterface.GetNumberOfPitchers();

            while (numberOfPitchers != 0)
                
                {
                    player1.inventory.iceCubes.RemoveRange(0, player1.recipe.numberOfIceCubes);
                    player1.inventory.lemons.RemoveRange(0, player1.recipe.numberOfLemons);
                    player1.inventory.sugarCubes.RemoveRange(0,player1.recipe.numberOfSugarCubes);
                    numberOfPitchers--;
                }


            

        }
      

        public void Customers()

        {
            Day day = new Day();


            int customersPerDay = day.NumberOfCustomersPerDay;
            while (customersPerDay != 0)
            {
               Customer customer = new Customer();
                customer.Purchase();        
                customersPerDay--;

            }

        }
        public void RunGame()
        {

            WelcomeMessage();
            for (int i = 0; i < 7; i++)
            {
                
                DayCreation();
                PlayerInventory();
                PurchaseIngrediants();
                //PlayerInventory();
                LemonadeRecipe();
                Pitchers();
                Customers();
            }


        }


















    }




}
