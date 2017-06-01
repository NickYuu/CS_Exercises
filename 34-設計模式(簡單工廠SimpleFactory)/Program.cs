using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using _34_設計模式_簡單工廠SimpleFactory_.Classes;

namespace _34_設計模式_簡單工廠SimpleFactory_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 簡單工廠模式: 通過專門定義一個類來負責創建其他類的實例，被創建的實例通常都具有共同的父類。
            Console.WriteLine("我們提供兩種產品\n1, MacBook\t2, Lenove");
            Console.WriteLine("請輸入 1 或 2 。");
            var s = Console.ReadLine();
            check(ref s);
            var nb = NBFactory(s);
            Console.WriteLine($"好的這是你的 {nb.Name} ");
            Console.WriteLine("\n開機試試看吧\n");
            Console.ReadKey();
            Console.WriteLine(nb.SayHello());
            Console.ReadKey();
        }

        static void check(ref string s)
        {
            while (true)
            {
                try
                {
                    var i = Convert.ToInt32(s);
                    if (i > 0 && i < 3)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("輸入有誤請從新輸入");
                        s = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("輸入有誤請從新輸入");
                    s = Console.ReadLine();
                }
            }
        }

        static NoteBook NBFactory(string s)
        {
            NoteBook nb = null;
            switch (s)
            {
                case "1":
                    nb =  new MacBook();
                    break;
                case "2":
                    nb =  new Lenovo();
                    break;
            }
            return nb;
        }
    }
}
