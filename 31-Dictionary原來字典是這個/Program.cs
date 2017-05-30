using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Dictionary原來字典是這個
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string,int>();
            dic.Add("1", 1);
            //dic.Add("1", 1); // 報錯 "已經加入含有相同索引鍵的項目。"
            dic["2"] = 2;

            // https://msdn.microsoft.com/zh-tw/library/5tbh8a42(v=vs.110).aspx
            foreach (var item in dic)
            {
                Console.WriteLine($"KEY:{item.Key}\tVALUE:{item.Value}");
            }
            Console.ReadKey();

        }
    }
}
