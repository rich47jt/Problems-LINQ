using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQProblemOne problemOne = new LINQProblemOne();
            LINQProblemOne.ListReader();

            LINQProblemTwo problemTwo = new LINQProblemTwo();
            LINQProblemTwo.DupicateDeleter();

            // LINQProblemThree problemThree = new LINQProblemThree();
            // LINQProblemThree.GradeCalculator();

            LINQProblemFour problemFour = new LINQProblemFour();
            LINQProblemFour.WordMachine();
        }
    }
}
