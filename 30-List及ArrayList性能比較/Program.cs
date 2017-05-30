using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_List及ArrayList性能比較
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            var arrList = new ArrayList();

            sw.Start();
            for (int i = 0; i < 10000000; i++)
            {
                arrList.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

            var list = new List<int>();

            sw.Reset();
            sw.Start();
            for (int i = 0; i < 10000000; i++)
            {
                list.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
