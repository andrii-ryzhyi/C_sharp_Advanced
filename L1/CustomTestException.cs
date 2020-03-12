using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class CustomTestException : Exception
    {
        public CustomTestException()
        {

        }
        public CustomTestException(string message) : base(message)
        {
        }
        public CustomTestException(string message, Exception inner) : base(message, inner)
        {

        }
    }
   
}
