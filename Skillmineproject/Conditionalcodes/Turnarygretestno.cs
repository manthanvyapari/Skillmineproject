using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Turnarygretestno
    {
        static void Main(string[] ags)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the value of num1");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of num2");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the alue of num3");
            num3 = int.Parse(Console.ReadLine());

            int g = num1 > num2 ? num1 > num3 ? num1 : num3 : num2 > num3 ? num2 : num3;

            {
                Console.WriteLine(g);
            }

        }
    }
}
