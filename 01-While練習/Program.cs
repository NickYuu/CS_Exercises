using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_While練習
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "";
            var maxNum = 0;

            while (str != "q")
            {
                Console.WriteLine("輸入數字,直到輸入q結束");
                str = Console.ReadLine();
                if (str != "q")
                {
                    try
                    {
                        var num = Convert.ToInt64(str);
                        if (num > maxNum)
                        {
                            maxNum = (int) num;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("輸入有誤");
                    }
                }
                else
                {
                    Console.WriteLine("剛剛輸入最大值為{0}", maxNum);
                }
            }
            Console.ReadKey();

        }
    }
}
