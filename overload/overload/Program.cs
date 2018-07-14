using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static double computeArea(double width)
        {
            double radius = width / 2;
            return((radius * radius) * 3.14593);
        }
    }
}
