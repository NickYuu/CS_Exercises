using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_方法使用及文檔註釋
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入兩個數，取大");
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("大數為" + GetMaxWhith(num1, num2).ToString());

            Console.ReadKey();
        }

        /// <summary>
        /// 帶入兩個數，返回較大的數字。
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>較大的數</returns>
        private static int GetMaxWhith(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
    }
}
