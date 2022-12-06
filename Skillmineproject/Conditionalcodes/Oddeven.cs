using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Oddeven
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is odd");            }
        }
       

    
    }
}
