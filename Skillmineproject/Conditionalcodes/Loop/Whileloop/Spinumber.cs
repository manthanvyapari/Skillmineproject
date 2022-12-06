using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop.Whileloop
{
    class Spinumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int product = 1;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                product = product * digit;
                num = num / 10;
            }

            if (sum == product)
            {
                Console.WriteLine("Number is Spynumber");
            }
            else
            {
                Console.WriteLine("Not Spynumber");
            }
        }     



   }

}
