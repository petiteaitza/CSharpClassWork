using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static string userName; // needs static so string can be accessed like public 
        static int userAge;

        static void Main(string[] args)
            
        {
            setUser("Aitza", 22);
            int number = 11;
            int result = doubler(number);
        }



        static string getWeight()
        {
            return "test";
        }

        static int doubler(int victim)
        {
            victim = victim * 2;
            return victim;
        }

        static void setUser(string name, int age)
        {
            userName = name;
            userAge = age;
      
        }
    }
}
