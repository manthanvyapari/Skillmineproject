using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop.Whileloop
{
    class Disariuamnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int temp2 = num;
            int sum = 0;
            int countdigit= 0;
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                countdigit++;
            }
            num = temp;
            while (num > 0)
            {
                int digit = num % 10;
                int power = 1;
                for(int i = 1; i<= countdigit;i++)
                {
                    power = power * digit;
                    
                    
                }
                sum = sum + power;
                num = num / 10;
                countdigit--;

            }
            if (temp2 == sum)
            {
                Console.WriteLine( "Is Disarium Number");
            }
            else
            {
                Console.WriteLine("Its not Disarium Number");
            }
           
           


                
            


        }
    }
}
