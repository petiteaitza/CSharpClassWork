using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Triangle : Polygon
    {
        public int area()
        {
            return ((width * height) / 2);
        }
        public override int showNumSides()
        {
            Console.WriteLine("Triangle Sides");
            int sides = base.showNumSides(); // example of hiding base methods

            Console.WriteLine(sides);
            return sides;

        }
    }
}
