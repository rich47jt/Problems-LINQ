using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class LINQProblemOne
    {
       
       public static void ListReader()
       {
            
            var wordlist = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var reader = (wordlist.Where(w => w.Contains("th")));
            foreach(string word in reader)
            {
                Console.WriteLine(word);
            }
              Console.ReadLine();
                
            
       }
       
    }
}
