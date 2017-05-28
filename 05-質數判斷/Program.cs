using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_質數判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n請輸入一個數 >");
                var numStr = Console.ReadLine();
                var num = 0;
                var readOK = int.TryParse(numStr, out num);
                if (readOK)
                {
                    if (isPrime(num))
                    {
                        Console.WriteLine("{0} 是質數!", num);
                    }
                    else
                    {
                        Console.WriteLine("{0} 不是質數!", num);
                    }

                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                }
            }
        }

        static bool isPrime(int k)
        {
            var isPrime = true;
            for (int i = 2; i < k; i++)
            {
                if (k % i == 0)
                {
                    isPrime = false;
                }
            }

            if (k == 0 || k == 1)
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}
