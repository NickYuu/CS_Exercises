using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_計算一字串中字符出現的數量
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = $"The popular C# programming language combines the high productivity of rapid application development languages with the raw power of C and C++. Updated to cover the new features of C# 4.0, including dynamic binding, named and optional parameters, and covariant and contravariant generic types, this release takes the language to the next level by adding the ability to cleanly write programs that don't rely on static type definitions. This allows dynamic programming languages such as Python, Ruby, and JavaScript to feel native to C#.The C# Programming Language, Fourth Edition,continues to be the authoritative and annotated technical reference for C# 4.0.";

            //計算這段文字，每個字符出現的次數。
            Console.WriteLine("計算這段文字，每個字符出現的次數。");
            Console.WriteLine(str);

            var dic = new Dictionary<char, int>();
            var chars = str.ToLower().ToCharArray();

            foreach (var c in chars)
            {
                if (c == ' ')
                {
                    continue;
                }
                if (!dic.ContainsKey(c))
                {
                    dic[c] = 1;
                }
                else
                {
                    dic[c]++;
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine("字符 {0} 出現 {1} 次", item.Key, item.Value);
            }
            Console.ReadKey();

        }
    }
}
