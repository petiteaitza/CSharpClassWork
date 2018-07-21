using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Polygon> polygons = new List <Polygon>();

            polygons.Add(new Rectangle()); // form of upcasting because polygon is rectangle base class
            polygons.Add(new Triangle());

            polygons[0].setValues(4, 5, 5);
            polygons[1].setValues(2, 6, 3);

           foreach(Polygon poly in polygons)
            {
                poly.showNumSides();
            }



            //Rectangle rect = new Rectangle();
            //Triangle cone = new Triangle();

            //rect.setValues(4, 5,4);
            //cone.setValues(4, 5,3);

            //Console.WriteLine(" Rectangle area:" + rect.area());
            //Console.WriteLine("Triangle area:" + cone.area());

            //Console.WriteLine(  rect.showNumSides());
            //Console.WriteLine( cone.showNumSides());

            Console.ReadKey();
        }
    }
}
