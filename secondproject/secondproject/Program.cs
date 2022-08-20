using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 11;
            int b = 100;

            int c = a * b;
            Console.WriteLine(c);

            var d = (double)b / a;
            Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
