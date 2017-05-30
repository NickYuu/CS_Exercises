using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_解構函數destructor
{
    class Person
    {
        ~Person()
        {
            Console.WriteLine("### release ###");
        }
    }
}
