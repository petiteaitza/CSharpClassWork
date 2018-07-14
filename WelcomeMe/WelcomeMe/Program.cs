using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Aitza";
            Console.WriteLine("Please Enter Your Name");
            ((name != "Aitza") ? Console.WriteLine("Welcome Aitza");:  Console.WriteLine("Leave Now"););
            

            Console.ReadKey();



        }
    }
}
