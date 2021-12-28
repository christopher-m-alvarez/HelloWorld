using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte b = 1;
            // int i = b;
            // Console.WriteLine(i);

            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
        }
    }
}
