using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class LINQProblemTwo
    {
       public static void DupicateDeleter()
       {
            var namelist = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var deleter = namelist.Distinct();
            foreach (string name in deleter)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
       }
    }
}
