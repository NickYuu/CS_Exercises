using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_多態
{
    class Bird: Flyable
    {
        public virtual string Eat()
        {
            return "我是一隻小鳥，我喜歡吃米。";
        }

        public string Fly()
        {
            return "我是一隻小鳥，我可以飛。";
        }
        
    }
}
