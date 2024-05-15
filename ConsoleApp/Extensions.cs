using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class CommonExtensions
    {
        public static void Print(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("--- x ---");
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine($"Array: {string.Join(",", array)}");

            Console.WriteLine("--- x ---");
        }

    }
}
