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
        private int dayCounter;
        public Weather Weather = new Weather();
        public Store Store = new Store();
        public List<Customer> Customers = new List<Customer>();
        private int numberOfCustomersPerDay;

        public Day()
        {
            this.random = new Random();
            this.Weather = new Weather();
            this.Customers = new List<Customer>();
            
            


        }
        
        public int DayCounter
        {
            get
            {


                return dayCounter++;
            }
            

        }
        //public int NumberOfCustomersPerDay
        //{
        //    get
        //    {
        //        return this.numberOfCustomersPerDay;
        //    }
        //    set
        //    {
        //        int numberOfCustomers;
        //        if( Weather.realConditions == "mostly sunny" ) 
        //        { 
        //            for( int i = 0; i == 50; i++)
        //            {
        //               Customer customer = new Customer();
        //                customer.Purchase();

        //            }
        //            this.numberOfCustomersPerDay = value;
        //        }
        //        else if (Weather.realConditions == "mostly cloudy")
        //            {
        //                for (int i = 0; i == 30; i++)
        //                {
        //                    Customer customer = new Customer();
        //                     customer.Purchase();

        //            }
        //                this.numberOfCustomersPerDay = value;
        //            }
        //        else if (Weather.realConditions == "sunny")
        //        {
        //            for (int i = 0; i == 60; i++)
        //            {
        //                Customer customer = new Customer();
        //                customer.Purchase();
        //            }
        //            this.numberOfCustomersPerDay = value;

        //        }
        //        else if (Weather.realConditions == "cloudy")
        //        {
        //            for (int i = 0; i == 25; i++)
        //            {
        //                Customer customer = new Customer();
        //                customer.Purchase();
        //            }
        //            this.numberOfCustomersPerDay = value;
        //        }
        //        else if (Weather.realConditions == "rainy")
        //        {
        //            for (int i = 0; i == 15; i++)
        //            {
        //                Customer customer = new Customer();
        //                customer.Purchase();
        //            }
        //            this.numberOfCustomersPerDay = value;
        //        }
        //        else if (Weather.realConditions == "partly cloudly")
        //        {
        //            for (int i = 0; i == 35; i++)
        //            {
        //                Customer customer = new Customer();
        //                customer.Purchase();
        //            }
        //            this.numberOfCustomersPerDay = value;
        //        }
        //        else if (Weather.realConditions == "sunny and rainy")
        //        {
        //            for (int i = 0; i == 20; i++)
        //            {
        //                Customer customer = new Customer();
        //                customer.Purchase();

        //            }
        //            this.numberOfCustomersPerDay = value;
        //        }
            
        



    }


    
    }

