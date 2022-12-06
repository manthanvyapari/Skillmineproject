using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Leapyear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) || (year % 400 == 0))
            {
                Console.WriteLine("The year is leap year");
            }
            else
            {
                Console.WriteLine("Its not a leap year");
            }
        }

    }
}
