using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_設計模式_簡單工廠SimpleFactory_.Classes
{
    /// <summary>
    /// 抽象類別
    /// https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/abstract
    /// </summary>
    public abstract class NoteBook
    {
        public virtual string Name { get; }
        public abstract string SayHello();
    }
}
