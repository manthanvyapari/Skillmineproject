using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Daynumber
    { static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter any Number");
            n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("MONDAY");
            }
            else if(n==2)
            {
                Console.WriteLine("TUESDAY");
            }
            else if (n == 3)
            {
                Console.WriteLine("WEDNESDAY");
            }
            else if (n == 4)
            {
                Console.WriteLine("THURSDAY");
            }
            else if (n == 5)
            {
                Console.WriteLine("FRIDAY");
            }
            else if (n == 6)
            {
                Console.WriteLine("SATURDAY");

            }
                else if (n == 7)
            {
                Console.WriteLine("SUNDAY");
            }

        }   
    }
}
