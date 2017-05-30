using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_多態
{
    class Eagle: Bird, Flyable
    {
        public override string Eat()
        {
            return "我是一隻老鷹，我喜歡吃肉。";
        }

        public string Fly()
        {
            return "我是一隻老鷹，我可以飛。";
        }
    }
}
