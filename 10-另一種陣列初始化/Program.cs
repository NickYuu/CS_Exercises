using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_另一種陣列初始化
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {5, 12, 53, 12, 12};

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                Console.ReadKey();
            }

        }
    }
}
