using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args) // ref pgs 66 &67
        {
            int output = factorial(5);
            Console.WriteLine("factorial of 5:" + output);
        }

        static int factorial(int num)
        {
            int result;
            if (num == 1)
            {
                result = 1;
            }
            else
            {
                result = (factorial(num - 1) * num); // if you didn't have this end, it would be infinite recursion which would cause a crash
            }
            return result;
        }
       
    }
}
