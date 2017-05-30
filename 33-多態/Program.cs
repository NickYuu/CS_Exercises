using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_多態
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird[] birds = {new Bird(), new Eagle()};
            foreach (var bird in birds)
            {
                Console.WriteLine(bird.Eat());
            }
            Console.ReadKey();
            Console.WriteLine("-----");
            Flyable[] flys = {new Bird(), new Eagle()};
            foreach (var fly in flys)
            {
                Console.WriteLine(fly.Fly());
            }
            Console.ReadKey();
        }
    }
}
