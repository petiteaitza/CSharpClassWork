using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            string input = Console.ReadLine();
            int divisor = Convert.ToInt32(input);

            int x = divide( divisor);

            Console.WriteLine("Answer =" + x);

            Console.WriteLine(x);
        }

        static int divide(int divisor)
        {
            return (10 / divisor);
        }
    }
}
