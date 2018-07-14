using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int i = 0;

            while (i < nums.Length)
            {
                nums[i] = i;
                Console.Write(" | " + nums[i]);
                i++;
            
            }
            Console.Write("n\n");

            do // seince we put test at end, it will execute at least once
            {
                i--;
                Console.Write("|" + nums[i]);
            }
            while (i > 0);
            Console.ReadKey();
        }
    }
}
