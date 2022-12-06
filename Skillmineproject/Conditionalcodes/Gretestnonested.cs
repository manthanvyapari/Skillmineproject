using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Gretestnonested
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the 1st number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd number");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("1st number is greter");

                }
                else
                {
                    Console.WriteLine("3rd  number is greter");
                }
            }
            else
            {
                if (num2 > num1)
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("2nd number is greter");
                    }
                }
            }

                

                
                    
                    

                
            
                    

                    
                
            
                

            
















































        }
    }
}




        

