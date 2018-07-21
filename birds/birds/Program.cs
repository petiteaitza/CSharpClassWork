using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird jean = new Bird();
            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();

            describe(jean);
            describe(joey);
            describe(lola);
            Console.ReadKey();

        }
        static void describe(Bird obj)
        {
            obj.talk();
            obj.fly();
        }
    }

    public class Bird
    {
        public virtual void talk()
        {
            Console.WriteLine ("A bird talks...");
        }

        public virtual void fly()
        {
            Console.WriteLine("A bird flys");

        }
    }

    public class Pigeon : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Pigeon says : Cool! Cool!");
        }

        public override void fly()
        {
            Console.WriteLine("A pigeon flys away");
            base.fly();
        }
    }

    public class Chicken : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Pigeon says : cluck! cluck!");
        }

        public override void fly()
        {
            Console.WriteLine("I'm a chicken. I can't fly!");
            base.fly();
        }
    }
}
