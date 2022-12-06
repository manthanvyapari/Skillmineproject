using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.Sorting_Array
{
    class Decendingorder
    {
        public int[] Mysort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] <a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }



        static void Main(string[] args)
        {
            int[] arr = { 8, 3, 5, 1, 9 };
            Console.WriteLine(string.Join("  ", arr));
            Decendingorder s = new Decendingorder();
            s.Mysort(arr);
            Console.WriteLine("......" + string.Join(" ", s.Mysort(arr)));
        }
    }



    
}

