using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP
{
    class Bubble_sort
    {
       public static void Bubble()
        {
            int[] Array = new int[] { 5, 2, 4, 6, 8, 1, 3, 7, 9 };
            for (int i = 0; i <Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1 - i; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        int a = Array[j];
                        Array[j] = Array[j + 1];

                        Array[j + 1] = a;
                    }

                }
            }
                foreach (int number in Array)
                Console.WriteLine(number);
        }


    }
}
