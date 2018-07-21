using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Rectangle : Polygon // adding the colon is how you inherit
    {
        public int area()
        {
           
            return (width * height);
        }

        public override int showNumSides()
        {
            Console.WriteLine("Rectangle Sides");
            int sides = base.showNumSides();

            Console.WriteLine(sides);
            return sides;

        }
        
    }
}
