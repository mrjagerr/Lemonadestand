using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        Random random;
        public string conditions;
        public int temperature;
        private List<string> weatherconditions;
        public string predictiedForcast;
        public string actualForcast;
        public string realConditions;
        public Weather()

        { 

            random = new Random();  
            weatherconditions = new List<string> { "Mostly sunny", "mostly cloudy", "Sunny", "Cloudy", "Rainy", "Partly cloudly", "Sunny and rainy" };
            predictiedForcast = weatherconditions[random.Next(0,weatherconditions.Count)];
            actualForcast = weatherconditions[random.Next(0, weatherconditions.Count)];
            temperature = Temperature;
            conditions = Conditions;
            realConditions = RealConditons;
        }



        public int Temperature
        {
            get
            {
                
                return  random.Next(55, 98); 

            }
            
        }
        public List<string> WeatherConditions

        {
            get
            {
                return weatherconditions;
            }
            set
            {


                weatherconditions = value;

            }


        }

        public string Conditions
        {
            get {

                return $"The weather of the day is {temperature} degrees and {predictiedForcast}.";
            }
            
          
        }
        public string RealConditons
        {
            get
            {
                return $"The weather of the day is actually {Temperature} degrees and {actualForcast}.";
            }
        }
       
         
       

    }
}
