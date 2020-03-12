using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public static class SportCarExtensions
    {
        public static void TuneUp(this ref int power, int delta)
        {
            power += delta;
        }
    }
}
