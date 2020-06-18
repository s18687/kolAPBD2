using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolAPBD2.Exceptions
{
    public class Exc : Exception
    {
        public Exc(string message)
            : base(message)
        {
        }
        public Exc(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        public Exc()
        {
        }
    }
}

