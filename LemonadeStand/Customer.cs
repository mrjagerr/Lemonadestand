using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {

        Recipe recipe;
        Weather weather;
        Random random = new Random();
        private int temperatureEnjoyment;
        private double priceOfPurchase;

        public Customer()
        {
            this.random = new Random();
            this.weather = new Weather();


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

            if (priceOfPurchase == recipe.price)
            {

                switch (weather.actualForcast)
                {
                    case "mostly sunny":
                        if (temperatureEnjoyment > 65)
                        {
                            Console.WriteLine("Customer will purchase");
                        }
                        else if (temperatureEnjoyment < 65)
                        {
                            Console.WriteLine("Customer walks by");
                        }
                        return;
                    case "mostly cloudy":
                        if (temperatureEnjoyment > 75)
                        {
                            Console.WriteLine("Customer will purchase");
                        }
                        else if (temperatureEnjoyment < 75)
                        {
                            Console.WriteLine("Customer walks by");
                        }
                        return;
                    case "sunny":
                        if (temperatureEnjoyment > 60)
                        {
                            Console.WriteLine("Customer will purchase");
                        }
                        else if (temperatureEnjoyment < 60)
                        {
                            Console.WriteLine("Customer walks by");
                        }
                        return;
                    case "cloudy":
                        if (temperatureEnjoyment > 80)
                        {
                            Console.WriteLine("Customer will purchase");
                        }
                        else if (temperatureEnjoyment < 80)
                        {
                            Console.WriteLine("Customer walks by");
                        }
                        return;
                    case "rainy":
                        if (temperatureEnjoyment > 85)
                        {
                            Console.WriteLine("Customer will purchase");
                        }
                        else if (temperatureEnjoyment < 85)
                        {
                            Console.WriteLine("Customer walks by");
                        }
                        return;
                    case "partly cloudly":
                        if (temperatureEnjoyment > 70)
                        {
                            Console.WriteLine("Customer will purchase");
                        }
                        else if (temperatureEnjoyment < 70)
                        {
                            Console.WriteLine("Customer walks by");
                        }
                        return;
                    case "sunny and rainy":
                        if (temperatureEnjoyment > 80)
                        {
                            Console.WriteLine("Customer will purchase");
                        }
                        else if (temperatureEnjoyment < 80)
                        {
                            Console.WriteLine("Customer walks by");
                        }
                        return;
                }
            }
        }
    }

    
}
