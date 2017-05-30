using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_繼承
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Nick", "25");
            Console.WriteLine(p.SayHello());
            Console.ReadKey();
            Console.WriteLine("---------------");
            var pm = new Programmer("Nick", "25", "Swift");
            Console.WriteLine(pm.SayHello());
            Console.ReadKey();
        }
    }
}
