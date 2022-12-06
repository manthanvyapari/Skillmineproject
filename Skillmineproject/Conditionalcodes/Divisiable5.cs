using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Divisiable5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            if ((num % 5 == 0))
            {
                Console.WriteLine("The number is divisible by 5");

            }
            else
            {
                Console.WriteLine("Not divisible by 5");
            }

        }
    }
}
