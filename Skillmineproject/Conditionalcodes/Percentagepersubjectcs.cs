using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Percentagepersubjectcs
    { 
        static void Main(string[] args)
        {
            int maths, phy, chem, eng, mar;
            double per, total;

            Console.WriteLine("Enter the marks of maths");
            maths = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of phy");
            phy= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of chem");
            chem =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of eng");
            eng =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of mar");
            mar = int.Parse(Console.ReadLine());

            total = maths + phy + chem + eng + mar;

            per = (total / 500) * 100;
            


            if (per >=70)
            {
                Console.WriteLine("Distingtion");

            }
            else if (per >=60)
            {
                Console.WriteLine("Frist class");
            }
            else if (per >=50)
            {
                Console.WriteLine("Second class");
            }
            else
            {
                Console.WriteLine("fail");

            }

            

            

































            }
    }
}
