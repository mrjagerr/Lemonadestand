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
        Weather Weather = new Weather();

        public Day()
        {

            dayCounter = 0;

            


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

