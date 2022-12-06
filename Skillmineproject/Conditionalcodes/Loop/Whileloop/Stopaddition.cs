using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop.Whileloop
{
    class Stopaddition
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while (i <= 20)
            {
                sum = sum + 1;
                if (sum > 10)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
