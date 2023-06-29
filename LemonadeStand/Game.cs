using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LemonadeStand
{
    internal class Game
    {
        Player player1 = new Player();
        Day day = new Day();
        
        
        //[8:20 PM] step2 Start first day

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
            //[8:25 PM] 2.8 State the weather and temp to signify the weather of the day
            Day day = new Day();
            
            Console.WriteLine($"It is currently Day{day.Daycounter}.");
            Console.WriteLine(day.Weather.Conditions);


        }


        public void PurchaseIngrediants()
        {
            //[8:21 PM] 2.3 Allow the player to go to the store to get ingredients (edited)
            // easy scaleable code  open/closed principle purpose is only to use the store
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

            int amountOfLemonsToRemove = numberOfPitchers * player1.recipe.numberOfLemons;
            int amountOfIceCubesToRemove = numberOfPitchers * player1.recipe.numberOfIceCubes;
            int amountOfSugarCubesToRemove = numberOfPitchers * player1.recipe.numberOfSugarCubes;
            int amountOfCupsToRemove = numberOfPitchers * 8;
            while (numberOfPitchers != 0)

            {
                if (player1.inventory.iceCubes.Count >= amountOfIceCubesToRemove && player1.inventory.lemons.Count >= amountOfLemonsToRemove && player1.inventory.sugarCubes.Count >= amountOfSugarCubesToRemove && player1.inventory.cups.Count >= amountOfCupsToRemove)

                {
                    player1.inventory.iceCubes.RemoveRange(0, player1.recipe.numberOfIceCubes);
                    player1.inventory.lemons.RemoveRange(0, player1.recipe.numberOfLemons);
                    player1.inventory.sugarCubes.RemoveRange(0, player1.recipe.numberOfSugarCubes);
                    player1.inventory.cups.RemoveRange(0, 8);
                    player1.inventory.AddLemonadeToInventory(8);
                    numberOfPitchers--;

                }
                else
                {
                    Console.WriteLine("You do not have enough ingrediants.");
                    numberOfPitchers = 0;
                    Pitchers();
                }
            }
            
      
        }
      
        public void PriceChange()
        {
            //[8:25 PM] 2.7 Select price per cup.
            Console.WriteLine("Would you like to change the price per cup of lemonade?Y/N");
            string response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                Console.WriteLine("What would you like the new price to be?");
                player1.recipe.price = Convert.ToDouble(Console.ReadLine());
                

               

            }
            else if (Console.ReadLine() == "N")
            {
                return;
            }
        }

        public void Customers()
        {
            //[8:23 PM] 2.5 Display actual forecast for the day
            //[8:26 PM] 2.9 Customer buy loop on a random purchase
            Console.WriteLine(day.Weather.RealConditons);
            int customersPerDay = day.NumberOfCustomersPerDay;
            int numberOfLemonadePurchaseable = player1.inventory.lemonades.Count;

            while (customersPerDay != 0 && numberOfLemonadePurchaseable != 0)
            {
                Customer customer = new Customer();
                customer.Weather = day.Weather;
                customer.RecipePrice = player1.recipe.price;
                customer.Purchase();
                if (customer.customerDecision == true)
                {
                    numberOfLemonadePurchaseable--;
                    player1.wallet.AcceptMoney(player1.recipe.price);
                    player1.score += player1.recipe.price;


                }
                    customersPerDay--;

                
            }
        }
        public void NewBalance()
        {
            //[8:27 PM] 2.10 Finish first day with results of sales and number of cups sold. As well as the amount made that day.
            Console.WriteLine($"You now have {player1.wallet.Money} in your wallet after todays sales.");
            Console.WriteLine($" You have made {player1.score}$ so far keep up the good work.");
            player1.inventory.lemonades = new List<Lemonade>();
            day = new Day();

        }
        public void NewGame()
        {
            Console.WriteLine("Would you like to play again");
            
            string response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                for (int i = 0; i < 7; i++)
                {

                    DayCreation();
                    PlayerInventory();
                    PurchaseIngrediants();
                    LemonadeRecipe();
                    Pitchers();
                    PriceChange();
                    Customers();
                    NewBalance();
                }



            }
            else if (Console.ReadLine() == "N")
            {
                return;
            }
        }
        public void Displaywinnings()
        {
            Console.WriteLine($" You have made a total of {player1.score}$ good job.");
        }

        public void RunGame()
        {

            //[8:28 PM] step 3 Repeat of step 2.1-2.10 (edited)
            //[8:29 PM] step 4 Repeat of 7 times with for each loop
            WelcomeMessage();
            for (int i = 0; i < 7; i++)
            {
                
                DayCreation();
                PlayerInventory();
                PurchaseIngrediants();
                LemonadeRecipe();
                Pitchers();
                PriceChange();
                Customers();
                NewBalance();
            }
            NewGame();
            Displaywinnings();


        }


















    }




}
