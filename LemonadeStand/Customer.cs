using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        Random random;
        Weather weather;
        private string tasteProfile;
        private string climateEnjoyemnet;
        private int temperatureEnjoyment;
        private int priceOfPurchase;

        public Customer() 
        {
        this.random = new Random();
        tasteProfile = string.Empty;
        climateEnjoyemnet = string.Empty;
        temperatureEnjoyment = 0;
        priceOfPurchase = 0;
            
        }   

        public string TasteProfile
        {
            get
            {
                return tasteProfile;
            }
            set
            {
                if(weather.temperature < 60)
                {

                }
            
            }
        }

        



    }
}
