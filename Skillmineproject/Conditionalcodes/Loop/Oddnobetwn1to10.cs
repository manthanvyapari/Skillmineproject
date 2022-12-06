using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop
{
    class Oddnobetwn1to10
    {
        static void Main(string[] args)
        {
            int i = 1;
            
            while (i <= 10)
            {
                if (i % 2== 0)
                {
                  
                    i++;
                    
                    continue;
                }

                Console.WriteLine(i);
                i++;
            }
           

            
              

                
            
        }
    }
}
