using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Input";

            Console.Write("Please Enter a Number");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter Another Number");
            double sum = number + Convert.ToDouble(Console.ReadLine()); // form of conversion


            Console.WriteLine("Total =" + sum);
            Console.ReadKey();
        }
    }
}
