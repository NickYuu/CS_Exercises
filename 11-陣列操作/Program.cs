using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_陣列操作
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1, 2, 3, 4, 5, 6] 取最大值, 最小值 , 合計 , 平均值
            int[] array = { 1, 2, 3, 4, 5, 6 };
            var max = int.MinValue;
            var min = int.MaxValue;
            var sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }

                if (min > array[i])
                {
                    min = array[i];
                }

                sum += array[i];
            }

            Console.WriteLine("[1, 2, 3, 4, 5, 6] 取最大值, 最小值 , 合計 , 平均值");
            Console.WriteLine("最大值是{0}, 最小值是 {1}, 合計 {2}, 平均值 {3}", max, min, sum, sum / array.Length);


            Console.ReadKey();

        }
    }
}
