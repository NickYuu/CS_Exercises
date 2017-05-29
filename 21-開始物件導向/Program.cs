using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_開始物件導向
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Nick", 25);
            Console.WriteLine(p.SayHello());
            Console.ReadKey();

        }
    }
}
