using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_距離計算票價
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("計算票價");
            Console.WriteLine("前一百公里每公里10元，一百公里後每公里8元，請輸入距離");
            while (true)
            {
                var t = new Ticket(GetDouble(Console.ReadLine()));
                Console.WriteLine(t.GetPrice());
            }
        }

        /// <summary>
        /// 將輸入的字串轉為Double
        /// </summary>
        /// <param name="s">輸入的字串</param>
        /// <returns>轉換後的Double</returns>
        private static double GetDouble(string s)
        {
            while (true)
            {
                try
                {
                    var d = Convert.ToDouble(s);
                    return d;
                }
                catch
                {
                    Console.WriteLine("輸入有誤請重新輸入");
                    s = Console.ReadLine();
                }
            }
        }
    }
}
