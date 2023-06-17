using System;
using System.Collections.Generic;
using System.Linq;
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

        public Weather(Random random)

        {
            this.random = random;
            temperature = (0);
            weatherconditions = new List<string> { "Mostly sunny", "mostly cloudy", "Sunny", "Cloudy", "Rainy", "Partly cloudly", "Sunny rainy" };
            
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

        



    }
}
