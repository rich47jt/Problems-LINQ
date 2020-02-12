using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class LINQProblemThree
    {
        public static void GradeCalculator()
        {
           List<string> classGrades = new List<string>(){"80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
           List<int> firstgradeNum  = classGrades.Select(f => int.Parse(f)).ToList();
           firstgradeNum.Remove(firstgradeNum.Min());

            
            
           

           



            
           

            



        }
    }
}
