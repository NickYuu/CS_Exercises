using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_字串操作
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "-hello,world-";
            Console.WriteLine("字串分割");
            var sArr = s.Split(new char[] {'-', ','});
            foreach (var t in sArr)
            {
                Console.WriteLine(t);
            }
            Console.ReadKey();
        }
    }
}
