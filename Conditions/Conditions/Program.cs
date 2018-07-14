using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 8;
            int b = 3;

            string verb = (a != 1) ? "are" : "is";
            Console.Write("There" + verb + a + "\n");

            Console.ReadKey();
        }
    }
}
