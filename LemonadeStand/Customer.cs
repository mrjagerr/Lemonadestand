using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
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

        
        // public void Purchase(Weather weather,Inventory inventory)
        //{
        //  if (temperatureEnjoyment <= weather.temperature) 
        //    {
        //        Console.WriteLine("Customer bought lemonade.");
        //        inventory.cups.RemoveAt(1);

        //    }
        //}
            


        
        
        
    }
}
