using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public abstract class Car
    {
        public abstract void Drive(int distance);
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting Engine ...");
        }
        public virtual void StopEngine()
        {
            Console.WriteLine("Stopping Engine ...");
        }

    }
}
