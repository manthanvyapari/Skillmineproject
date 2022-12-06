using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject
{
    class Arearectangle
    {
        static void Main(string[] args)
        {
            int b, h;
            Console.WriteLine("Emter the value for b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for h");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine(0.5* b * h);
        }
    }
}
