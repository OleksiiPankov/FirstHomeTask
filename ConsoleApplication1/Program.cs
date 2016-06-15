using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int len = n;
            Random r = new Random();
            for (int i = 0; i < len; i++)
            {
                array[i] = r.Next(-100, 101);
            }
            Console.WriteLine("Массив до сортировки");
            for (int i = 0; i < len; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            QuickSorting.QuickSort(array, 0, len - 1);
            Console.WriteLine("Массив после сортировки");
            for (int i = 0; i < len; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
//комент для изменений