using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LineComparison
{
    class CalculateDistance
    {
        public void DistanceResult()
        {
           

            int x1, y1, x2, y2;
            double result;
            Console.WriteLine("Enter the Co-ordinates of first point as A(x1,y1) : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of second point as B(x2,y2) : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The Length of 2 points is : "+result);    
            
        }

        
        }
    }

