using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop.Whileloop
{
    class Sumoffactorial1to5
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int sum = 0;
             
            for(int i = 1; i <= 5; i++)
            {
                fact = fact * i;
            }
            sum = sum + fact;

            Console.WriteLine("Factorial of number=" + fact);
            Console.WriteLine("Sum of factorial=" + sum);

        }
    }
}
