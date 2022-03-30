using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's hot!");
                    break;

                default:
                    Console.WriteLine("I dont understand that season");
                    break;
            }


            //bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95F;
            //else
            //    price = 29.95F;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);


        }
    }
}
