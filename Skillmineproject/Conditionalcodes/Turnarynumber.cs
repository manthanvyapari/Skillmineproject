using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Turnarynumber
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any  number");
            num = int.Parse(Console.ReadLine());
            string result = num >= 0 ? "No is positve" : "No is negetive" ;
            Console.WriteLine(result);

            


        }
    }
}