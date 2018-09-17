/*
1. Перерозташувати елементи у масиві( відємні, невідємні) у порядку їх  слідування. 
Для масиву : 1  2 -4  -55  -7 10 100
Повинні отримати змінений масив: -4  -55  -7  1 2 10 100
Використати FindAll(), CopyTo().
 */


using System;
using System.Linq;

namespace _01_sort_array
{
    class Program
    {
        static void Print(int[] arr, string message = "")
        {
            Console.WriteLine(message);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}\t");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int[] arr = { 1,  2, - 4, - 55, - 7, 10, 100 };
            int[] arrSort = new int[arr.Length];
            int minus = arr.Count(x => x < 0);

            int[] tmp = Array.FindAll(arr, (x) => (x < 0));
            tmp.CopyTo(arrSort, 0);
            tmp = Array.FindAll(arr, (x) => (x >= 0));
            tmp.CopyTo(arrSort, minus);

            Print(arr, "Before:");
            Print(arrSort, "After:");
        }
    }
}
