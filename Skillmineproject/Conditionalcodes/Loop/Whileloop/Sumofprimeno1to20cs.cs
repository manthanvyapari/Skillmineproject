using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop.Whileloop
{
    class Sumofprimeno1to20cs
    {
        static void Main(string[] args)
        {
            int sum = 0;
            float avarage = 0;
            for(int num = 1; num <= 20; num++)
            {
                bool isprime = true;
                for(int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(num);
                    sum = sum + num;
                    avarage = sum /num;
                }
            }
            Console.WriteLine("Sum of prime=" + sum);
            Console.WriteLine("Avarage of prime NO=" + avarage);


        }
    }
}
