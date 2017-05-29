using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LOL牌位Enum
{
    enum LOL {銅排,銀排,金排,白金,鑽石,大師,菁英}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入你的LOL牌位0~6..");
            var urLol = (LOL)Enum.Parse(typeof(LOL), Console.ReadLine());
            Console.WriteLine(urLol.ToString());
            Console.ReadKey();
        }
    }
}
