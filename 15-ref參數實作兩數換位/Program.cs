using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ref參數實作兩數換位
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("將n1 = 20, n2 = 100 變成 n1 = 100, n2 = 20");
            var n1 = 20;
            var n2 = 100;
            Change(ref n1, ref n2);
            Console.WriteLine("n1 = {0}", n1);
            Console.WriteLine("n2 = {0}", n2);
            Console.ReadKey();
        }

        private static void Change(ref int n1, ref int n2)
        {
            var temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
