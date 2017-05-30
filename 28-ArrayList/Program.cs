using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 在ArrayList中添加隨機1~10不重複
            var al = new ArrayList();
            var r = new Random();

            for (int i = 0; i < 10; i++)
            {
                var num = r.Next(1, 11);
                if (!al.Contains(num))
                {
                    al.Add(num);
                }
                else
                {
                    i--;
                }
            }

            foreach (var num in al)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
