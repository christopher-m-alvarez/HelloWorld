using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            Console.WriteLine(numbers);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);


            var names = new string[3] { "jack", "john", "mary" };
            Console.WriteLine(names);
        }
    }
}
