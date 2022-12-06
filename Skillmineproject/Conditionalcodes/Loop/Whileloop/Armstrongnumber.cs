using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop.Whileloop
{
    class Armstrongnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = 0;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + (digit * digit * digit);
                num = num / 10;
            }
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("Number is Armstrong");

            }
            else
            {
                Console.WriteLine("NOT armstrong");
            }


        }
    }
}
