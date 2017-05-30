using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "";
            var sw = new Stopwatch();
            Console.WriteLine("String 拼接 50000次需要");
            sw.Start();
            for (int i = 0; i < 50000; i++)
            {
                s += i;
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

            sw.Reset();
            var sb = new StringBuilder();
            Console.WriteLine("StringBuilder 拼接 50000次需要");
            sw.Start();
            for (int i = 0; i < 50000; i++)
            {
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
