﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes.Loop
{
    class Oddevenbetwn120to81
    {
        static void Main(string[] args)
        {
           for(int i=120; i >= 81; i--)
            {
                if (i %2! == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
