using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_設計模式_簡單工廠SimpleFactory_.Classes
{
    class Lenovo: NoteBook
    {
        public override string Name => "Lenovo";
        public override string SayHello()=> $"{Name}, 聯想都不用想";
        
    }
}
