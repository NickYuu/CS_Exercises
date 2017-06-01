using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_解構函數destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 目前不知如何測試.....
            // 重新new讓他沒有被引用居然不會release

            var p = new Person();
            var i = 0;
            
            while (true)
            {
                Console.WriteLine(i);
                p = new Person();
                System.GC.Collect();
                Console.ReadKey();
                i++;
            }
            
        }
    }
}
