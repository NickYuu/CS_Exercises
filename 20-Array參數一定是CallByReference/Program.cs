using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Array參數一定是CallByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Nick", "Tom", "Jeffrey", "Ian" };
            Reverse(names);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
        #region 反轉陣列方法
        /// <summary>
        /// 反轉陣列
        /// </summary>
        /// <param name="strArr"></param>
        private static void Reverse(string[] strArr)
        {
            for (int i = 0; i < strArr.Length / 2; i++)
            {
                var temp = strArr[i];
                strArr[i] = strArr[strArr.Length - 1 - i];
                strArr[strArr.Length - 1 - i] = temp;
            }
        }
        #endregion
    }
}
