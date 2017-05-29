using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_判斷年月日
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入年 > ");
            try
            {
                var year = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("輸入月份");
                try
                {
                    var month = Convert.ToInt64(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {
                        var day = 0;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2:
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                day = 30;
                                break;
                        }
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("月份輸入有誤");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
