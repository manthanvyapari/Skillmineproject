using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Switchevenodd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());

            switch (num %2==0)
            {
                case true:
                    Console.WriteLine(num + "Number is even");
                    break;
                case false:
                    Console.WriteLine(num + "Number is odd");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
        }
        

       
            
               
            
        
    }
}
