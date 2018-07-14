using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 10)
            {
                if(y > 10)
                Console.WriteLine("y > 10");
                
            }

            else
            {
                Console.WriteLine("y < = 10");

            }
            Console.ReadKey();
        }
    }
}
