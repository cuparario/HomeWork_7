/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная 
с конца. Использовать рекурсию, не использовать циклы. */

        
using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            ReverseArray(array);
        }

        private static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                var temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }

            Console.WriteLine("Результат: " + string.Join<int>(" ", array));
        }
    }
}