using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal  class Day
    {

        Random random;
        private static int dayCounter=0;
        public Weather Weather = new Weather();
        public Store Store = new Store();
        public List<Customer> Customers = new List<Customer>();
        private int numberOfCustomersPerDay;
        
        public Day()
        {
            this.random = new Random();
            this.Weather = new Weather();
            this.Customers = new List<Customer>();
           
            numberOfCustomersPerDay = NumberOfCustomersPerDay;
            
            
        }
        public int Daycounter
        {
            get
            {
                dayCounter++;
                return dayCounter; }

        }
        
            
        

                //weatherconditions = new List<string> { "mostly sunny", "mostly cloudy", "sunny", "cloudy", "rainy", "partly cloudly", "sunny and rainy" };

            
        public  int NumberOfCustomersPerDay
        {
            get

            {

                switch (Weather.actualForcast)
                {
                    case "mostly sunny":
                        numberOfCustomersPerDay = 30;
                        return numberOfCustomersPerDay;
                    case "mostly cloudy":
                        numberOfCustomersPerDay = 20;
                        return numberOfCustomersPerDay;
                    case "sunny":
                        numberOfCustomersPerDay = 40;
                        return numberOfCustomersPerDay;
                    case "cloudy":
                        numberOfCustomersPerDay = 25;
                        return numberOfCustomersPerDay;
                    case "rainy":
                        numberOfCustomersPerDay = 10;
                        return numberOfCustomersPerDay;
                    case "partly cloudy":
                        numberOfCustomersPerDay = 25;
                        return numberOfCustomersPerDay;
                    case "sunny and rainy":
                        numberOfCustomersPerDay = 15;
                        return numberOfCustomersPerDay;


                }
                return numberOfCustomersPerDay;
            }
           

            
        }
    }
 }

