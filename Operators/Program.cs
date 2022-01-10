using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(c > b || c > a);

            // Console.WriteLine(c > b && c > a);

            // var a = 1;
            // var b = 2;
            // 
            // Console.WriteLine(a < b);


            //var a = 1;
            //var b = 2;
            //var c = 3;
            //
            //Console.WriteLine((a + b) * c);


            //var a = 10;
            //var b = 3;
            //
            //Console.WriteLine(a + b);
            //Console.WriteLine((float)a / (float)b);
        }
    }
}
