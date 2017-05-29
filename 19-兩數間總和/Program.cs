using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_兩數間總和
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入兩個數字，計算這兩個數字之間所有整數的和");
            Console.WriteLine("請輸入第一個數字");
            var s1 = Console.ReadLine();
            var n1 = GetNum(s1);
            Console.WriteLine("請輸入第二個數字");
            var s2 = Console.ReadLine();
            var n2 = GetNum(s2);
            Judge(ref n1, ref n2);
            var sum = Sum(n1, n2);
            Console.WriteLine("{0} 和 {1} 兩數之間整數合為{2}", n1, n2, sum);
            Console.ReadKey();
        }

        /// <summary>
        /// 把字串轉換為數字不能轉換重新輸入
        /// </summary>
        /// <param name="s">要轉換的字串</param>
        /// <returns>轉換後的數字</returns>
        private static int GetNum(string s)
        {
            while (true)
            {
                try
                {
                    var i = Convert.ToInt32(s);
                    return i;
                }
                catch
                {
                    Console.WriteLine("輸入有誤，請重新輸入");
                    s = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 判斷第二個數是否大於第一個數
        /// </summary>
        /// <param name="n1">第一個數</param>
        /// <param name="n2">第二個數</param>
        private static void Judge(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("第一個數需小於第二個數，請重新輸入第一個數");
                    n1 = GetNum(Console.ReadLine());
                    Console.WriteLine("重新輸入第二個數");
                    n2 = GetNum(Console.ReadLine());
                }
            }
        }

        /// <summary>
        /// 計算兩數間整數和
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        private static int Sum(int n1, int n2)
        {
            var sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
