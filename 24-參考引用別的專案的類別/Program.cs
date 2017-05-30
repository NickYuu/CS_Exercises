using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _23_距離計算票價;

namespace _24_參考引用別的專案的類別
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1, 點擊參考右鍵 > 加入參考 > 專案 > 方案
            // 2, 將namespace加入using
            var t = new Ticket(101);
            Console.WriteLine(t.GetPrice());
            Console.ReadKey();
        }
    }
}
