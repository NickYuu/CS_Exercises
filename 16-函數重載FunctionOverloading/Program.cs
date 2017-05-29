using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_函數重載FunctionOverloading
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
            
            Console.WriteLine("\n\n將s1 = Hello, s2 = World 變成 s1 = World, s2 = Hello");
            var s1 = "Hello";
            var s2 = "World";
            Change(ref n1, ref n2);
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.ReadKey();
        }

        private static void Change(ref int n1, ref int n2)
        {
            var temp = n1;
            n1 = n2;
            n2 = temp;
        }

        private static void Change(ref string s1, ref string s2)
        {
            var temp = s1;
            s1 = s2;
            s2 = temp;
        }
    }
}
