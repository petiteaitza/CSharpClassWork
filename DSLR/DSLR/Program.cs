using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLR
{
    class Program
    {
        private static string tagC;

        static void Main(string[] args)
        {
            Camera canon = new Camera();
            canon.setValues("Mark 6D", "100 GB", "50mm 1.2");
            string tagC = String.Format("This {0} has  {1} of memory and  {2} lens attached",
                canon.getName(),
                canon.getMemory(),
                canon.getLens()

                );


            Console.WriteLine(tagC + canon.snap()); 
                   


            Console.ReadKey();
        }
    }


    class Camera
    {

        private string name, memory, lens;


        public void setValues(string name, string memory, string lens)
        {
            this.name = name;
            this.memory = memory;
            this.lens = lens;
        }


        public string getName() { return name; }
        public string getMemory() { return memory; }
        public string getLens() { return lens; }

        public string snap()
        {
            return "\nImage Capture Details!\n";
        }
    }
}

 

   

