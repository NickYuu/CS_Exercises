using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_九九乘法
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.Write("{0}x{1}={2}\t", j, i, i*j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
