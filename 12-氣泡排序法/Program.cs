using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_氣泡排序法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 41, 38, 24, 51, 12, 35, 97, 17, 23, 0 };

            Console.WriteLine("[ 41, 38, 24, 51, 12, 35, 97, 17, 23, 0 ] 排序\n");
            Console.WriteLine("\n----------------------\n");
            Console.WriteLine("系統的升序  Array.Sort(array) ");

            Array.Sort(array);
            foreach (var t in array)
            {
                Console.Write(t.ToString() + "  ");
            }

            Console.WriteLine("\n\n----------------------\n");
            Console.WriteLine("系統陣列反轉  Array.Reverse(array); ");

            Array.Reverse(array);
            foreach (var t in array)
            {
                Console.Write(t.ToString() + "  ");
            }

            Console.WriteLine("\n\n----------------------\n");
            Console.WriteLine("氣泡排序");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    var temp = array[i];
                    if (array[j] < array[i])
                    {
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            foreach (var t in array)
            {
                Console.Write(t.ToString() + "  ");
            }

            Console.ReadKey();
        }
    }
}
