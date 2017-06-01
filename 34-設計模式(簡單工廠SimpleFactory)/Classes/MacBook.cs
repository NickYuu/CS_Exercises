using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_設計模式_簡單工廠SimpleFactory_.Classes
{
    class MacBook: NoteBook
    {
        public override string Name => "MacBook";

        public override string SayHello()=> $"{Name}, 重新定義任何東西..";
        
    }
}
