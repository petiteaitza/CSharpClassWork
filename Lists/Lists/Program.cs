using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            
            for(int i=0; i<10; i++)
            {
                list.Add(i * 2);
            
            }
            for (int i = list.Count-1 ; i >0; i--)
            {
                Console.WriteLine("Element" + i + "=" + list[i]);
            }

            Console.ReadKey();
        }
    }
}
