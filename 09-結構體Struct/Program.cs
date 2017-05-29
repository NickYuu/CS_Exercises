using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_結構體Struct
{
    public enum Gender {男,女}

    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("請輸入名字");
            p._name = Console.ReadLine();
            Console.WriteLine("請輸入年齡");
            try
            {
                p._age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("輸入錯誤");
                Console.ReadKey();
            }
            Console.WriteLine("請輸入性別男 = 0, 女 = 1");
            var num = -1;
            var isGenderOK = int.TryParse(Console.ReadLine(), out num);
            if (isGenderOK)
            {
                if (num == 0 || num == 1)
                {
                    p._gender = (Gender) num;
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("輸入錯誤");
                Console.ReadKey();
            }
            Console.WriteLine("你的名字是{0}, {1}歲, {2}生", p._name, p._age, p._gender.ToString());
            Console.ReadKey();
        }
    }
}
