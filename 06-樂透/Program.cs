using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_樂透
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var totalArr = new int[42];
                var resultArr = new ArrayList();
                var r = new Random();

                for (int i = 0; i < 42; i++)
                {
                    totalArr[i] = i + 1;
                }

                while (resultArr.Count < 6)
                {
                    var ran = r.Next(0, 42);
                    if (!resultArr.Contains(totalArr[ran]))
                    {
                        resultArr.Add(totalArr[ran]);
                    }
                }
                resultArr.Sort();
                for (int i = 0; i < resultArr.Count; i++)
                {
                    Console.WriteLine(resultArr[i]);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
