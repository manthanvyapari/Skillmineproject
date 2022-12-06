using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop.While_loop
{
    class Sumofoddbetn1to20
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
                while (i <= 20)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                    i++;
                    continue;
                 
                }
                Console.WriteLine("sum" + i);
                i++;
                
            }
        }
    }
}
