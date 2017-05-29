using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_out參數實作登入提示
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入帳號");
            var name = Console.ReadLine();
            Console.WriteLine("請輸入密碼");
            var pwd = Console.ReadLine();
            string msg;
            Console.WriteLine("是否登入:" + IsLogin(name, pwd, out msg));
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        private static bool IsLogin(string name, string pwd, out string msg)
        {
            bool login = false;
            if (name == "admin" && pwd == "123456")
            {
                msg = name + "歡迎回來";
                login = true;
            }
            else if (name == "admin")
            {
                msg = "密碼有誤";
            }
            else
            {
                msg = "帳號有誤";
            }
            return login;
        }
    }
}
