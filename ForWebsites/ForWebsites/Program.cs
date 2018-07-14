using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForWebsites
{
    class Program
    {
        static void Main(string[] args)
        {
           // string[] websites = new string[5] { "Google", "YouTube", "Tumblr", "Facebook", "Yahoo!" };

         //  Console.WriteLine("Popular Websites");

            // foreach loop example begins here

            int rank = 1;
            Dictionary<string, string> booklist = new Dictionary<string, string>();

            booklist.Add("Adeyemi ", "Children of Blood and Bone");
            booklist.Add("L. Penelope", " A Song of Blood and Stone");
            booklist.Add("Olivia A Cole", "A Conspiracy of Stars");

            Console.WriteLine("Popular Titles");

            foreach (KeyValuePair<string, string> book in booklist)
            {
                Console.WriteLine("Keys:" + book.Key + "\tValue:" + book.Value + "in easy steps");
            }
            Console.ReadKey();
        }

           //for(int j = 0; j < websites.Length; j++) example of for loop 
           // {
               
             //   if (j == 4)
             //       break;// nothing after this will be outputted 
              //  if (j == 2)
               //     continue;

              //  Console.WriteLine("Positions;" + rank + "\t" + websites[j]);
              //  rank++;
          //  }
           
        }
    }
