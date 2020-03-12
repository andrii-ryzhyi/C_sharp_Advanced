using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public static class TestExtensions
    {
        public static void Add(this ref int i, int value)
        {
            i += value;
        }
    }
}
