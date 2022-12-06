using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop
{
    class Dividedby5and3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if ((i % 5 == 0)&& (i % 2 == 3))
                {
                    Console.WriteLine(i);
                }
            }
            
             
            
                
            
        

                
        }
    }
}
