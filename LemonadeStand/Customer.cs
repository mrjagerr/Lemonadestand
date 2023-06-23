using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        Player player;
        Recipe recipe;
        Weather weather;
        Random random = new Random();
        private int temperatureEnjoyment;
        private double priceOfPurchase;

        public Customer() 
        {
            Random random = new Random();


        temperatureEnjoyment = TemperatureEnjoyment;
        priceOfPurchase = PriceOfPurchase;
            
        }
        public double PriceOfPurchase
        {
            get
            {
                
                return random.Next(0, 4);

            }
           
        }
        
        public int TemperatureEnjoyment
        {
            get
            {

                return random.Next(55, 98);

            }

        }


        public void Purchase()
        {
           
            if (recipe.price == priceOfPurchase || weather.temperature == TemperatureEnjoyment)
            {
                Console.WriteLine("Customer has purchased Lemonade");
                
            }
            else if (recipe.price !=  priceOfPurchase|| weather.temperature < TemperatureEnjoyment)
                {
                Console.WriteLine("Customer walks by.");
            }

        }     







    }
}
