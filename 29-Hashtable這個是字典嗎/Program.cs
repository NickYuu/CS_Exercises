using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Hashtable這個是字典嗎
{
    class Program
    {
        static void Main(string[] args)
        {
            var ht = new Hashtable();
            ht.Add("1", "Hello");
            ht["2"] = "world";
            ht.Add(3,"哈哈");
            ht[3] = "你好";

            foreach (var key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }
            Console.ReadKey();
        }
    }
}
