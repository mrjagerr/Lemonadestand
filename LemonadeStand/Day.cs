using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {

        Random random;
        public int dayCounter;
        public Weather Weather = new Weather();
        public  Customer Customer = new Customer();
        public Store Store = new Store();
        public Day()
        {
            this.random = new Random();
            this.Weather = new Weather();
            Customers = new Customer();
            foreach (Customer customer in customers)
            {

            }



        }

        public int DayCounter
        {
            get
            {
                return ++dayCounter;
            }

        }




    }



}

