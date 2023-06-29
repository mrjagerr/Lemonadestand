using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {

        // open/closed principle  the ability to add fuctions  to change the customers decisions  without changing the existing ones is present could add the number of sugarcubes to effect the decision/ or number of icecubes
        
        Random random = new Random();
        private int temperatureEnjoyment;
        private double priceOfPurchase;
        private double recipePrice;
        private Weather weather;
        public bool customerDecision;
        public Customer()
        {

            this.random = new Random();
            


            temperatureEnjoyment = TemperatureEnjoyment;
            priceOfPurchase = PriceOfPurchase;


        }
        public double PriceOfPurchase
        {
            get
            {

                return random.Next(1, 4);

            }


        }

        public int TemperatureEnjoyment
        {
            get
            {

                return random.Next(55, 98);

            }




        }
        public double RecipePrice
        {
            set
            {
                recipePrice = value;
            }
        }
        public Weather Weather
        {
            set
            {
                weather = value;
            }

        }
       

        public void Purchase()
         {

            if (priceOfPurchase <= recipePrice)
            {

                switch (weather.actualForcast)
                {
                    case "mostly sunny":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                    case "mostly cloudy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by"); 
                                customerDecision = false;
                        }
                        return;
                    case "sunny":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                                customerDecision = false;
                        }
                        return;
                    case "cloudy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                    case "rainy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                                customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                                customerDecision = false;
                        }
                        return;
                    case "partly cloudy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase"); 
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                    case "sunny and rainy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                }
            }
            else if (priceOfPurchase >= recipePrice)
            {

                switch (weather.actualForcast)
                {
                    case "mostly sunny":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by"); 
                            customerDecision = false;
                        }
                        return;
                    case "mostly cloudy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                    case "sunny":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                    case "cloudy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                    case "rainy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                    case "partly cloudy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                    case "sunny and rainy":
                        if (temperatureEnjoyment >= weather.temperature)
                        {
                            Console.WriteLine("Customer will purchase");
                            customerDecision = true;
                        }
                        else if (temperatureEnjoyment <= weather.temperature)
                        {
                            Console.WriteLine("Customer walks by");
                            customerDecision = false;
                        }
                        return;
                }
            }
        }
    }  
}
