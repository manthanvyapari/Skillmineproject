using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.OOPs
{
    class Car
    {
        int modelno;
         string carname;
            string carprize;
            string carcolor;

        static void Main(string[] args)
        {
            Car c = new Car();
            c.modelno = 112233;
            c.carname = "MahidraThar";
            c.carprize="18.75l";
            c.carcolor = "Black";
            Console.WriteLine(c.modelno + "  " + c.carname + "  "+c.carprize + "  " + c.carcolor);


            Car c2 = new Car();
            c2.modelno = 445566;
            c2.carname = "Fortuner";
            c2.carprize = "40L";
            c2.carcolor = "White";
            Console.WriteLine(c2.modelno + "  " + c2.carname + "  "+c2.carprize + "  " + c2.carcolor);


            Car c3 = new Car();
            c3.modelno = 778899;
            c3.carname = "TATA Harrier";
            c3.carprize = "20L";
            c3.carcolor = "Brown";
            Console.WriteLine(c3.modelno + "  " + c3.carname +"  " + c3.carprize + "  " + c3.carcolor);
        }
            
    }
   
}
