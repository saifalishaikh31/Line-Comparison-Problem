using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            CalculateDistance calulatedistance = new CalculateDistance();
            calulatedistance.DistanceResult();
            Console.ReadLine();
        }
    }
}
