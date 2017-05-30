using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_繼承
{
    public class Programmer: Person
    {
        public string Langue { get; set; }

        public Programmer(string name, string age, string langue)
            :base(name, age)
        {
            this.Langue = langue;
        }

        public override string SayHello()
        {
            return $"你好我是 {Name}， 今年 {Age} 歲， 熟悉語言是{Langue}";
        }
    }
}
