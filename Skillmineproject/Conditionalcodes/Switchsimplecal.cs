using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Conditionalcodes
{
    class Switchsimplecal
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("Enter the num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("(+) Addition" );
            Console.WriteLine("(-) Subtraction");
            Console.WriteLine("(*) Multiplication");
            Console.WriteLine("(/) Division");
            Console.WriteLine("Enter the oprator(sign) for opration");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+': Console.WriteLine("Addition" + (num1 + num2));
                    break;
                case '-':Console.WriteLine("Subtraction" + (num1 -num2));
                    break;
                case '*':Console.WriteLine("multiplication" + (num1 * num2));
                    break;
                case '/':Console.WriteLine("Division" + (num1 / num2));
                    break;
                default:Console.WriteLine("INVALID OPERATOR");
                    break;



            }
            
              



            
                



        }
    }
}
