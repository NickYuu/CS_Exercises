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
            Console.WriteLine("輸入一個數,轉型成功返回ture");
            var num = 2;
            var isOK = int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(num);
            Console.WriteLine(isOK);
            Console.ReadKey();
        }
    }
}
