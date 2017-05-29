using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_params將數目不定的參數傳送至方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetTotalScore("Nick", 90, 89, 93, 60));
            Console.ReadKey();
        }

        private static string GetTotalScore(string name, params int[] score)
        {
            var sum = 0;
            foreach (var t in score)
            {
                sum += t;
            }
            return name + "本次總分為" + sum;
        }
    }
}
