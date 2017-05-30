using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_繼承
{
    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public Person(string name, string age)
        {
            this.Age = age;
            this.Name = name;
        }

        public virtual string SayHello()
        {
            return $"你好我是 {Name} , 今年 {Age} 歲";
        }
    }
}
