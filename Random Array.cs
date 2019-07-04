using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP
{
    class Random_Array
    {
        public static void Array()
        {
            int Lenth = 10;
            int[] Array = new int[Lenth];
            Array[0] = 2;
            Console.WriteLine(Array[0] + ",");

            for (int i = 1; i < Array.Length; i++)
            {

                Array[i] = Array[i - 1] + new Random().Next(0, 5);
                Console.Write(Array[i] + ",");
                Console.WriteLine();

            }
        }
    }
}     
    

