using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public abstract class AbstarctClass
    {
        public abstract void Method1();
        public virtual void Method2()
        {
            Console.WriteLine("Call from virtual method");
        }
        
    }
}
