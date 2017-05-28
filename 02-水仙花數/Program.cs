using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_水仙花數
{
    class Program
    {
        static void Main(string[] args)
        {
            // 100~999 中的水仙花數
            // 百位數的三次方 + 十位數的三次方 + 個位數的三次方 = 原三位數
            // 153 -> 1^3 + 5^3 + 3^3 = 153
            for (int i = 100; i < 1000; i++)
            {
                var a = i / 100;        // 百位數
                var b = i % 100 / 10;   // 十位數
                var c = i % 10;         // 個位數

                if (Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3) == i)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();

        }
    }
}
