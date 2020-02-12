using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class LINQProblemFour
    {
      public static void WordMachine()
      {
            var name = new List<string>() { "T", "e", "r", "r", "i", "l", "l" };
            var organizer = name.OrderByDescending(n => n.Length);
           
               foreach (string letter in organizer)
               {

                organizer.Concat(name);
                Console.WriteLine(name);
               }
            
            
           Console.ReadLine();
         
               
          
            
      }
    }
}
