using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.OOPs
{
    class Sumofevenelement
    {

        public void Sumeven(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {


                if (arr[i] % 2 == 0)
                {

                  
                    Console.WriteLine(arr[i]);
                }
               
            }
            
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter the arrat element");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

                 
            }

            Sumofevenelement see = new Sumofevenelement();
            see.Sumeven(a);
        }

    }
}
