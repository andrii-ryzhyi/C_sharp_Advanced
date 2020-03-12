using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public class SportCarException : Exception
    {
        public override string Message
        {
            get
            {
                return "Ooops. Something went wrong with the Sport Car!";
            }
        }

        public SportCarException()
        {
        }

        public SportCarException(string message) : base(message)
        {
        }

        public SportCarException(string message, Exception inner) : base(message, inner)
        {
        }

    }
}
