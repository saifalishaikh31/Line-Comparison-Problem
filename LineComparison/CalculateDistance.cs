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
            int x1, y1, x2, y2, x3, y3, x4, y4;
            double resultFirstLine, resultSecondLine;
            Console.WriteLine("Enter the Co-ordinates of First Linefirst point as A(x1,y1) : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of First Line second point as B(x2,y2) : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of Second Line first point as C(x3,y3) : ");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of Second second point as D(x4,y4) : ");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());

            resultFirstLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            resultSecondLine = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            int status = resultFirstLine.CompareTo(resultSecondLine);

            if (status > 0)
            {
                Console.WriteLine("{0} is greater than {1}", resultFirstLine, resultSecondLine);
            }
            if (status < 0)
            {
                Console.WriteLine("{0} is less than {1}", resultFirstLine, resultSecondLine);
            }
            else
            {
                Console.WriteLine("{0} is equal to {1}", resultFirstLine, resultSecondLine);
            }
        }

    }
}

