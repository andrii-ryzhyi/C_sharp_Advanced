using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public class Test
    {
        public int Age { get; set; }
        public String Name { get; set; }
        public double Result { get; set; }
        public int Cnt { get; }
        public int Cnt2 { get; private set; }

        private int count;
        private string lastName;

        public Test()
        {
            Age = 3;
            Name = "Test";
            Result = 0.1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
    }
    }
}
