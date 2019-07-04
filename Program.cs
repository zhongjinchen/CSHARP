using System;

namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 7, 13, 37, 47, 69, 79, 158, 378, 489 };
            Console.WriteLine("现有数组；1, 3, 7, 13, 37, 47, 69, 79, 158, 378, 489");

            int index = array.Length - 1;
            Console.WriteLine("请输入你要查找的数字");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < array. Length; i++)
            {
                int steps = (index + 1) / 2;
                if (input == array[index])
                {
                    Console.WriteLine();
                    Console.WriteLine($"找到了，共寻找{i}次，在第{index + 1 }个位置");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"第{i}次寻找，取第{index + 1 }个数,值为{array[index]}");
                    if (input > array[index])
                    {
                        index += steps;
                    }
                    else
                    {
                        index -= steps;
                    }
                    Console.WriteLine($"设下一次查找的位置为{index + 1}");
                    Console.WriteLine();
                }
            }
        }
    }
}
