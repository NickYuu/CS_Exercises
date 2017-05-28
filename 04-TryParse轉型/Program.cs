using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TryParse轉型
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 2;
            var isOK = int.TryParse("12a3", out num);
            Console.WriteLine(num);
            Console.WriteLine(isOK);
            Console.ReadKey();
        }
    }
}
